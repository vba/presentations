// Generated by CoffeeScript 1.7.1

/*

 * For
products = ['frogs', 'cheese', 'beer', 'burger']
eat = (food) -> console.log "I'm eating #{food}" 

eat food for food in products

 * I'm a french
eat food for food in products when food is 'frogs' or food is 'chees' 

 * Intervals
countdown = (num for num in [10..1])

 * Maps
yearsOld = max: 10, ida: 9, tim: 11
 */


/*
ages = for child, age of yearsOld when age > 10
    console.log "#{child} is #{age} and can drink the beer"
 */

(function() {
  var lyrics, num;

  num = 3;

  lyrics = (function() {
    var _results;
    _results = [];
    while (num -= 1) {
      _results.push("" + num + " little monkeys, jumping on the bed. One fell out and bumped his head.");
    }
    return _results;
  })();

  console.log(lyrics);


  /*
   * For do
  
  for filename in ["a.txt", "b.txt"]
  	do (filename) ->  console.log "Working on #{filename}"
   */

}).call(this);

//# sourceMappingURL=Sample3.map
