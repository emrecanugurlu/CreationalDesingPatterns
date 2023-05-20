
Person person = new Person("Emre Can","UĞURLU",new Department("Yapay Zeka"),new Address("Türkiye", "Hatay", "Yayladağı"), 23,new List<string>{"Masa Tenisi"},true);

Person personClone = person.Clone();
personClone.Name = "Hasan";
Console.WriteLine();

interface IPersonClonable
{
    Person Clone();
}

class Person:IPersonClonable
{
    public Person(String name, String Surname, Department department, Address address, int Age, List<String> Hobies, bool isPremium)
    {
        this.Name = name;
        this.Surname = Surname;
        this.Department = department;
        this.Address = address;
        this.Age = Age;
        this.Hobies = Hobies;
        this.isPremium = isPremium;
    }

    public String Name { get; set; }
    public String Surname { get; set; }
    public Department Department { get; set; }
    public Address Address { get; set; }
    public int Age { get; set; }
    public List<String> Hobies { get; set; }
    public bool isPremium { get; set; }

    public Person Clone()
    {
        return (Person)base.MemberwiseClone();
    }

}

class Department
{
    public Department(String name)
    {
        this.Name = name;
    }
    public String Name { get; set; }
}

class Address
{
    public Address(String country, String city, String description)
    {
        this.Country = country;
        this.City = city;
        this.Description = description;
    }

    public String Country { get; set; }
    public String City { get; set; }
    public String Description { get; set; }
}
