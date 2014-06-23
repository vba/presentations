
gulp 		= require 'gulp'
gutil 		= require 'gulp-util'
concat 		= require 'gulp-concat'
coffee 		= require 'gulp-coffee'
mocha 		= require 'gulp-mocha-phantomjs'
clean 		= require 'gulp-clean'
uglify 		= require 'gulp-uglify'
watch 		= require 'gulp-watch'
plumber 	= require 'gulp-plumber'
jslint 		= require 'gulp-jslint-simple'

###
		Paths
###

filePaths = 
	app: 
		src: './Scripts/src/**/*.js'
		dest: './Scripts/out'

	test: 
		src: 
			coffee: './Scripts/test/**/*.coffee'
			html: './Scripts/test/**/*.html'
		dest: './Scripts/out'
		spec: './Scripts/out/specs.html' 

	jshint: 
		src: './Scripts/src/**/*.js'

	minifycss: 
		src: './Content/src/**/*.css'
		dest: './Content/out'

###
		Utils
###

CommonTasks = 
	compileSpecs: () ->
		gulp.src(filePaths.test.src.coffee)
			.pipe coffee({ bare: true }).on('error', gutil.log)
			.pipe gulp.dest filePaths.test.dest

		gulp.src(filePaths.test.src.html)
			.pipe gulp.dest filePaths.test.dest

	packageSrc: () ->
		gulp.src(filePaths.app.src)
			.pipe uglify()
			.pipe gulp.dest filePaths.app.dest

	compileSrc: () -> 
		gulp.src([filePaths.app.src, '!Scripts/src/default/**/*.js'])
			.pipe jslint.run 
				browser: true
				nomen: true
				todo: true
				white: true
				vars: true
				globals : 
					"define": false
					"console": false 
					"_": false 
			.pipe jslint.report()

		gulp.src(filePaths.app.src)
			.pipe gulp.dest filePaths.app.dest

	runSpecs: (silentMode) ->
		gulp.src(filePaths.test.spec)
			.pipe plumber()
			.pipe mocha({silentMode: Boolean(silentMode)})

###
		Tasks
###

gulp.task 'default', ['watch-src-js']

gulp.task 'clean-dest', -> 
	gulp.src([filePaths.app.dest, filePaths.test.dest])
		.pipe clean() 

gulp.task 'package-src',  ['clean-dest'],   -> CommonTasks.packageSrc()
gulp.task 'package-test', ['package-src'],  -> CommonTasks.compileSpecs()

gulp.task 'test', ['package-test'], ->
	gulp.src(filePaths.test.spec)
		.pipe mocha(dump: [filePaths.test.dest,'/', 'specs.repport.txt'].join(''))

gulp.task 'watch-src-js', ->
	watch {glob: [filePaths.app.src, filePaths.test.src.coffee]}, () ->
		CommonTasks.compileSrc()
		CommonTasks.compileSpecs()
		CommonTasks.runSpecs()

gulp.task 'watch-test-coffee', ->
	watch {glob: filePaths.test.src.coffee}, () ->
		CommonTasks.compileSpecs()
		CommonTasks.runSpecs()

