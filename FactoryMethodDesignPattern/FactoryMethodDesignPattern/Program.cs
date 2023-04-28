#region Yazılı Anlatım
//Operasyon süreçlerinde üretilecek nesnelerin türü/sınıfı/referansı yerine sadece kendisine odaklanıp işlemlerimizi devam ettirmek istediğimiz durumlarda kullanılanbir stratejidir.
//Factory Method Design Pattern, nesne oluşturma sorumluluğunu yardımcı bir sınıfa devrederek bu sürecin maliyetini ihtiyaç anından soyutlamaktadır.
//Kodlama sürecinde asıl odaklanmamız gereken kod kısmı olmasına rağmen, bizler bazen nesnenin oluşturulma sürecinde çok fazla boğulabilmekteyiz. Oluşturulacak olan nesnenin parametreleri bizleri asıl odaklanmamız gereken noktadan uzaklaştırabilir.Bu durumu egale edebilmek için nesne oluşturma işini ayrı bir sınıfa verip, istenilen nesneyi oradan temin ederiz.
//Nesne oluşturma kodunu, nesneyi gerçekten kullanacağımız koddan arındırmamız gerekir.

#endregion


A? a = ProductCreater.GetInstance(ProductType.A) as A;
B? b = ProductCreater.GetInstance(ProductType.B) as B;
C? c = ProductCreater.GetInstance(ProductType.C) as C;

class A : IProduct
{
    public A()
    {
        Console.WriteLine($"{nameof(A)} nesnesi oluşturuldu.");
    }
}

class B : IProduct
{
    public B()
    {
        Console.WriteLine($"{nameof(B)} nesnesi oluşturuldu.");
    }
}

class C : IProduct
{
    public C()
    {
        Console.WriteLine($"{nameof(C)} nesnesi oluşturuldu.");
    }
}


enum ProductType
{
    A, B, C
}

interface IProduct
{

}

class ProductCreater
{
    public static IProduct GetInstance(ProductType productType)
    {
        IProduct? instance = null;
        switch (productType) {
            case ProductType.A:
                instance =  new A();
                break;
            case ProductType.B:
                instance = new B();
                break;
            case ProductType.C:
                instance = new C();
                break;
        }
        return instance!;
    }
}