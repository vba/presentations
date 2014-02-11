#####################################################
#
#          		Loops
#
#####################################################

###

# For
products = ['frogs', 'cheese', 'beer', 'burger']
eat = (food) -> console.log "I'm eating #{food}" 

eat food for food in products

# I'm a french
eat food for food in products when food is 'frogs' or food is 'chees' 

# Intervals
countdown = (num for num in [10..1])

# Maps
yearsOld = max: 10, ida: 9, tim: 11

###

###
ages = for child, age of yearsOld when age > 10
    console.log "#{child} is #{age} and can drink the beer"
  
###

###

# While

num = 3
lyrics = while num -= 1
	"#{num} little monkeys, jumping on the bed. One fell out and bumped his head."

console.log lyrics

###

###
# For do

for filename in ["a.txt", "b.txt"]
	do (filename) ->  console.log "Working on #{filename}"

###

