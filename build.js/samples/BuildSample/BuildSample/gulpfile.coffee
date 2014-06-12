
gulp = require 'gulp'
gutil = require 'gulp-util'
concat = require 'gulp-concat'
coffee = require 'gulp-coffee'
jasmine = require 'gulp-jasmine'
clean = require 'gulp-clean'
uglify = require 'gulp-uglify'
size = require 'gulp-size'
watch = require 'gulp-watch'
fs = require 'fs'

###
		Paths
###

filePaths = 
    app: 
        src: './Scripts/src/**/*.js'
        dest: './Scripts/out/'

    jshint: 
        src: './Scripts/src/**/*.js'

    minifycss: 
        src: './Content/src/**/*.css'
        dest: './Content/out/'
    


###
		Tasks
###

gulp.task 'default', ['watch-src-js'], =>

gulp.task 'package-src', =>
	gulp.src(filePaths.app.src)
		.pipe uglify()
		.pipe size()
		.pipe gulp.dest filePaths.app.dest

gulp.task 'watch-src-js', =>
	watch {glob: filePaths.app.src}, () =>
		gulp.src(filePaths.app.src)
			.pipe gulp.dest filePaths.app.dest