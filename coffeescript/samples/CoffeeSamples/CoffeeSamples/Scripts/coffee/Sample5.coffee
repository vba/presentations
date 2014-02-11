#####################################################
#
#        Conditional and expressions at all
#
#####################################################

# If/Else as an expression

###
grade = (note) ->
	if /excellent/gi.test note
		if /really/gi.test note
			"A+"
		else
			"A"
	else if /okay/gi.test note 
		"B"
	else if /hard/gi.test note
		"B-"
	else
		"Go home loser"

console.log grade "Really excellent, Piter"
console.log grade "Excellent, Tevin"
console.log grade "You've tried hard, Simon"
console.log grade "Martin, you are stupid student"

###

# Switch

day = "Fri_Fun"

###

out1 = switch
	when day == "Mon" then "go work"
	when day is "Tue" then "go relax"
	when day is "Thu" then "go ice fishing"

	when /^(?:Fri|Sat)_Fun$/gi.test(day) then [
		"Drink a lot of beer, 5L",
		"Go dancing",
		"Drink again mixing beer and vodka",
		"Go dancing on the bar and fighting with a stuff",
	]
	when day is "Sun" then "go church"
	else "go work"

console.log out1

###

###
message = 
	try
		throw "Béjour I'm an error"
	catch error
		"Oh my goodness, #{error}"
	finally
		console.log "Make it finally"

console.log message

###

###
console.log "Is it exact, doctor ?  #{(200 > 127 > 60) }"
###

###
console.log """
	<!-- I love it, and I can't live without this little beauty -->
	<lovelyXml>
		<content>AAAAAA</content>
	</lovelyXml>
"""

###


###

six = (one = 1) + (two = 2) + (three = 3)
[ein, zwei] = [one, two]

console.log six
console.log one
console.log two
console.log three

console.log ein
console.log zwei

###