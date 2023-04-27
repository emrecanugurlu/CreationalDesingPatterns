//Uygulama bazında bir sınıfın sınırlı sayıda intance’sinin var olmasını sağlayan stratejidir.
var i1 = Example.GetInstance("mySql");
var i2 = Example.GetInstance("mongoDb");
var i3 = Example.GetInstance("MSSQL");

class Example
{
    private Example() {
        Console.WriteLine($"{nameof(Example)} nesnesi oluşturuldu...");
    }

    static Dictionary<string, Example> instanceDictionary;

    public static Example GetInstance(string key)
    {
        if (!instanceDictionary.ContainsKey(key))
        {
            instanceDictionary[key] = new Example();
        }
        return instanceDictionary[key];
    }
}
