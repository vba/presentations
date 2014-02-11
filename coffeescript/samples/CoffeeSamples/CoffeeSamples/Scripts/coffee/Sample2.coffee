#####################################################
#
#          Functions, splats and objects
#
#####################################################

square = (x) -> x * x
cube   = (x) -> square(x) * x

fill = (container, liquid = "coffee") ->
    "Filling the #{container} with #{liquid}..."

# Splats
gold = silver = rest = "unknown"

awardMedals = (first, second, others...) ->
  gold   = first
  silver = second
  rest   = others

contenders = [
  "Michael Phelps"
  "Liu Xiang"
  "Yao Ming"
  "Allyson Felix"
]

awardMedals contenders...

console.log "Gold: " + gold
console.log "Silver: " + silver
console.log "The Field: " + rest


# Objects

song = ["do", "re", "mi", "fa", "so"]

singers = {Jagger: "Rock", Elvis: "Roll"}

bitlist = [
    1, 0, 1
    0, 0, 1
    1, 1, 0
]

kids =
    brother:
        name: "Max"
        age:  11
    sister:
        name: "Ida"
        age:  9
    
outer = 1

# Scope

changeNumbers = ->
    inner = -1
    outer = 10

inner = changeNumbers()