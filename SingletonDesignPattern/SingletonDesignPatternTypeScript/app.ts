
class Example {
    private constructor() {
        console.log("Example nesnesi oluþturuldu...");
    }

    private static _instance: Example;

    static getInstance(): Example {
        if (this._instance == null)
            this._instance = new Example();
        return this._instance
    }
}

let i1 = Example.getInstance();
let i2 = Example.getInstance();
let i3 = Example.getInstance();
let i4 = Example.getInstance();


