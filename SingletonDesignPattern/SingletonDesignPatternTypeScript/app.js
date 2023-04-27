var Example = /** @class */ (function () {
    function Example() {
        console.log("Example nesnesi olu�turuldu...");
    }
    Example.getInstance = function () {
        if (this._instance == null)
            this._instance = new Example();
        return this._instance;
    };
    return Example;
}());
var i1 = Example.getInstance();
var i2 = Example.getInstance();
var i3 = Example.getInstance();
var i4 = Example.getInstance();
