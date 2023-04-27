var task1 = Task.Run(() => { Example.Instance(); });
var task2 = Task.Run(() => { Example.Instance(); });
var task3 = Task.Run(() => { Example.Instance(); });
await Task.WhenAll(task1, task2, task3);
var task4 = Task.Run(() => { Example.Instance(); });
var task5 = Task.Run(() => { Example.Instance(); });
var task6 = Task.Run(() => { Example.Instance(); });
await Task.WhenAll(task4, task5, task6);
class Example
{
    //Asenkron süreçleride Singleton yapısı aşağıdaki gibi kurulabilir. Bununla birlikte static constructor ile yapılan nesne oluştuma işleminde bir lock oluşturmaya gerek kalmayacaktır.
    private Example()
    {
        Console.WriteLine($"{nameof(Example)} nesnesi oluşturuldu.");
    }

    static Example _instance;

    static object _obj = new object();
    public static Example Instance()
    {
        lock (_obj)
        {
            if (_instance == null)
                _instance = new Example();
        }

        return _instance;
    }
}
