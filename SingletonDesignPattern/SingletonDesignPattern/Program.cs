var ins1 = Example.GetInstance;
var ins2 = Example.GetInstance;
var ins3 = Example.GetInstance;
var ins4 = Example.GetInstance;
var ins5 = Example.GetInstance;

class Example
{
    private Example()
    {
        Console.WriteLine($"{nameof(Example)} nesnesi oluşturuldu.");
    }

    private static Example _example;

    #region 1.Yöntem
    //public static Example GetInstance
    //{
    //    get
    //    {
    //        if (_example == null)
    //            _example = new Example();
    //        return _example;
    //    }
    //}
    #endregion
    #region 2.Yöntem
    static Example()
    {
        _example = new Example();
    }

    public static Example GetInstance
    {
        get
        {
            return _example;
        }
    }
    #endregion
}