
A? a = ProductCreator.GetProductInstance(ProductType.A) as A;
a!.Run();
B? b = ProductCreator.GetProductInstance(ProductType.B) as B;
b!.Run();
C? c = ProductCreator.GetProductInstance(ProductType.C) as C;
c!.Run();

interface IProduct
{
    public void Run();
}

class A : IProduct
{
    public void Run()
    {
        Console.WriteLine($"{nameof(A)} nesnesi oluşturuldu.");
    }
}
class B : IProduct
{
    public void Run()
    {
        Console.WriteLine($"{nameof(B)} nesnesi oluşturuldu.");
    }
}
class C : IProduct
{
    public void Run()
    {
        Console.WriteLine($"{nameof(C)} nesnesi oluşturuldu.");
    }
}

enum ProductType
{
    A,B,C
}

class ProductCreator
{

 
    public static IProduct GetProductInstance(ProductType productType)
    {
        ICreatorFactory? instance = null;
        switch (productType)
        {
            case ProductType.A: instance = new AProductCreatorFactory();
                break;
            case ProductType.B: instance = new BProductCreatorFactory();
                break;
            case ProductType.C: instance = new CProductCreatorFactory();
                break;
        }
        return instance!.GetProductInstance();
    }

}


interface ICreatorFactory
{
    IProduct GetProductInstance();
}


class AProductCreatorFactory : ICreatorFactory
{
    public IProduct GetProductInstance()
    {
        return new A();
    }
}

class BProductCreatorFactory : ICreatorFactory
{
    public IProduct GetProductInstance()
    {
        return new B();
    }
}

class CProductCreatorFactory : ICreatorFactory
{
    public IProduct GetProductInstance()
    {
        return new C();
    }
}