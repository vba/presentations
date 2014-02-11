var Eagle = (function () {
    function Eagle(name) {
        if (name == null) {
            name = "Bill";
        }
        this.name = name;
    }
    Eagle.prototype.walk = function () {
        console.log("[Eagle] I'm an eagle and I can walk ...");
    };
    Eagle.prototype.canFly = function () {
        return true;
    };
    return Eagle;
})();

var eagle = new Eagle("Bobby");
eagle.walk();

if (eagle.canFly()) {
    console.log("Mom, I can fly, I guess");
}
//# sourceMappingURL=SampleOOP.js.map
