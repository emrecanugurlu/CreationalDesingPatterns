
GarantiBank? garantiBank = CreationalBankFactory.GetInstance(BankType.GarantiBank) as GarantiBank;
HalkBank? halkBank = CreationalBankFactory.GetInstance(BankType.HalkBank) as HalkBank;
VakifBank? vakifBank = CreationalBankFactory.GetInstance(BankType.VakifBank) as VakifBank;

GarantiBank? garantiBank1 = CreationalBankFactory.GetInstance(BankType.GarantiBank) as GarantiBank;
HalkBank? halkBank1 = CreationalBankFactory.GetInstance(BankType.HalkBank) as HalkBank;
VakifBank? vakifBank1 = CreationalBankFactory.GetInstance(BankType.VakifBank) as VakifBank;

var a = GarantiBankCreationalFactory.GetFactoryInstance;
var b = HalkBankCreationalFactory.GetFactoryInstance;
var c = VakıfBankCreationalFactory.GetFactoryInstance;

var a1 = GarantiBankCreationalFactory.GetFactoryInstance;
var b1 = HalkBankCreationalFactory.GetFactoryInstance;
var c1 = VakıfBankCreationalFactory.GetFactoryInstance;



class GarantiBank : IBank
{
    string _userCode, _password;

    GarantiBank(string userCode, string password)
    {
        Console.WriteLine($"{nameof(GarantiBank)} nesnesi oluşturuldu.");
        _userCode = userCode;
        _password = password;
    }

    static GarantiBank instance;
    public static GarantiBank GetInstance
    {
        get
        {
            if (instance == null)
                instance = new("asd", "1234");
            return instance;
        }
    }

    public void ConnectGaranti()
    {
        Console.WriteLine($"{nameof(GarantiBank)} bağlantısı sağlandı.");
    }

    public void SendMoney(int amount)
    {
        Console.WriteLine($"{nameof(amount)} TL tutarında para gönderildi.");
    }
}

class HalkBank : IBank
{
    string _userCode, _password;

    HalkBank(string userCode)
    {
        Console.WriteLine($"{nameof(HalkBank)} nesnesi oluşturuldu.");
        _userCode = userCode;
    }

    static HalkBank instance;
    public static HalkBank GetInstance
    {
        get
        {
            if (instance == null)
                instance = new("qwert");
            return instance;
        }
    }

    public String Password { set { _password = value; } }
    public void Send(int amount, string accountNumber)
    {
        Console.WriteLine($"{nameof(amount)} TL tutarında para gönderildi.");
    }
}

class CredentialVakifBank
{
    public string UserCode { get; set; }
    public string Mail { get; set; }
}

class VakifBank : IBank
{
    string _userCode, _password, _email;

    VakifBank(CredentialVakifBank credential, string password)
    {
        Console.WriteLine($"{nameof(VakifBank)} nesnesi oluşturuldu.");
        _userCode = credential.UserCode;
        _email = credential.Mail;
        _password = password;
    }

    static VakifBank instance;
    public static VakifBank GetInstance
    {
        get
        {
            if (instance == null)
                instance = new(new() { Mail = "qewqe", UserCode = "234" }, "fskjvn");
            return instance;
        }
    }

    public void Send(int amount, string accountNumber)
    {
        Console.WriteLine($"{nameof(amount)} TL tutarında para gönderildi.");
    }
}


interface IBank
{

}

enum BankType
{
    GarantiBank,
    HalkBank,
    VakifBank
}

class CreationalBankFactory
{
    public static IBank GetInstance(BankType bankType)
    {
        IFactory factory = bankType switch
        {
            BankType.GarantiBank => GarantiBankCreationalFactory.GetFactoryInstance,
            BankType.HalkBank => HalkBankCreationalFactory.GetFactoryInstance,
            BankType.VakifBank => VakıfBankCreationalFactory.GetFactoryInstance
        };
        return factory.GetInstance();
    }
}

interface IFactory
{
    public IBank GetInstance();
}

class GarantiBankCreationalFactory : IFactory
{
    GarantiBankCreationalFactory()
    {
        Console.WriteLine($"{nameof(GarantiBankCreationalFactory)} nesnesi oluşturuldu.");
    }

    static GarantiBankCreationalFactory()
    {
        instance = new GarantiBankCreationalFactory();
    }

    static GarantiBankCreationalFactory instance;
    public static GarantiBankCreationalFactory GetFactoryInstance
    {
        get { return instance; } 
    }

    public IBank GetInstance()
    {
        GarantiBank instance = GarantiBank.GetInstance;
        return instance;
    }
}

class HalkBankCreationalFactory : IFactory
{
    HalkBankCreationalFactory()
    {
        Console.WriteLine($"{nameof(HalkBankCreationalFactory)} nesnesi oluşturuldu.");
    }
    static HalkBankCreationalFactory()
    {
        instance = new HalkBankCreationalFactory();
    }

    static HalkBankCreationalFactory instance;

    public static HalkBankCreationalFactory GetFactoryInstance { get { return instance; } }

    public IBank GetInstance()
    {
        HalkBank instance = HalkBank.GetInstance;
        return instance;
    }
}

class VakıfBankCreationalFactory : IFactory
{
    VakıfBankCreationalFactory()
    {
        Console.WriteLine($"{nameof(HalkBankCreationalFactory)} nesnesi oluşturuldu.");
    }

    static VakıfBankCreationalFactory()
    {
        instance = new VakıfBankCreationalFactory();
    }

    static VakıfBankCreationalFactory instance;

    public static VakıfBankCreationalFactory GetFactoryInstance { get { return instance; } }

    public IBank GetInstance()
    {
        VakifBank instance = VakifBank.GetInstance;
        return instance;
    }
}