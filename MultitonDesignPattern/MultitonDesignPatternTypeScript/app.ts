
class Example {
    private constructor() {
        console.log("Example nesnesi oluþturuldu.");
    }

    private static instanceMap: Map<string, Example> =new Map<string, Example>();

    static getInstance(key: string)
    {
        if (this.instanceMap.get(key) == null) {
            this.instanceMap.set(key, new Example())
        }
        return this.instanceMap.get(key);
    }
}

let i1 = Example.getInstance("a");
let i2 = Example.getInstance("b");
let i3 = Example.getInstance("a");
