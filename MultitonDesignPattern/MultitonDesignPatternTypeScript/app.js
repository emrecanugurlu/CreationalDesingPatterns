var Example = /** @class */ (function () {
    function Example() {
        console.log("Example nesnesi olu�turuldu.");
    }
    Example.getInstance = function (key) {
        if (this.instanceMap.get(key) == null) {
            this.instanceMap.set(key, new Example());
        }
        return this.instanceMap.get(key);
    };
    Example.instanceMap = new Map();
    return Example;
}());
var i1 = Example.getInstance("a");
var i2 = Example.getInstance("b");
var i3 = Example.getInstance("a");
