// Generated by CoffeeScript 1.7.1
(function() {
  var awardMedals, bitlist, changeNumbers, contenders, cube, fill, gold, inner, kids, outer, rest, silver, singers, song, square,
    __slice = [].slice;

  square = function(x) {
    return x * x;
  };

  cube = function(x) {
    return square(x) * x;
  };

  fill = function(container, liquid) {
    if (liquid == null) {
      liquid = "coffee";
    }
    return "Filling the " + container + " with " + liquid + "...";
  };

  gold = silver = rest = "unknown";

  awardMedals = function() {
    var first, others, second;
    first = arguments[0], second = arguments[1], others = 3 <= arguments.length ? __slice.call(arguments, 2) : [];
    gold = first;
    silver = second;
    return rest = others;
  };

  contenders = ["Michael Phelps", "Liu Xiang", "Yao Ming", "Allyson Felix"];

  awardMedals.apply(null, contenders);

  console.log("Gold: " + gold);

  console.log("Silver: " + silver);

  console.log("The Field: " + rest);

  song = ["do", "re", "mi", "fa", "so"];

  singers = {
    Jagger: "Rock",
    Elvis: "Roll"
  };

  bitlist = [1, 0, 1, 0, 0, 1, 1, 1, 0];

  kids = {
    brother: {
      name: "Max",
      age: 11
    },
    sister: {
      name: "Ida",
      age: 9
    }
  };

  outer = 1;

  changeNumbers = function() {
    var inner;
    inner = -1;
    return outer = 10;
  };

  inner = changeNumbers();

}).call(this);

//# sourceMappingURL=Sample2.map
