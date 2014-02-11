#####################################################
#
#             OOP and some of cool operators
#
#####################################################


class Animal
	walk: -> throw "Not yet implemented"

class Eagle extends Animal
	constructor: (@name) ->
	walk: -> console.log "[Eagle] I'm an eagle, my name is #{@name} and I can walk, walk ..."
	canFly: -> yes

eagle = new Eagle('Karl')
eagle.walk()

console.log "I can fly" if eagle.canFly()

###
# Elvis is back, baby 

#[drogs, alcohol, rockAndRoll] = [true, !!(yes * 10), on]

howami = "live is cool" if drogs? and alcohol? and rockAndRoll?
console.log "Today, upon me, #{howami ? 'it sucks'}"

###

###
	lives: (country) ->
		if country is 'usa'
			address:
				street: 'White house'
		else
			address: 'rubbish heap'

console.log "It's a big cheese eagle" if eagle.lives?('usa')?.address?.street is 'White house'

###

###
# Functions binding

console.log eagle.walk.call(console)

###


###

# Destructuring assignment

sendToJail =
	vbCreator: "Tevin F***er"
	tsqlGenerator:
		name:   "Le Jacques"
		address: [
			"Rue de la prison 10"
			"75010"
			"Paris"
			"France"
		]

{tsqlGenerator: {name, address: [street, zip, city, country]}} = sendToJail

console.log "#{name} for all of your crimes against the humanity, I'll come for you to #{city} and I'll send you to the jail"

###