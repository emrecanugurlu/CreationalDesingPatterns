var Person = /** @class */ (function () {
    function Person(name, surname, age, department, address, isPremium) {
        this.name = name;
        this.surname = surname;
        this.age = age;
        this.department = department;
        this.address = address;
        this.isPremium = isPremium;
        console.log("Person oluşturuldu.");
    }
    Person.prototype.clone = function () {
        return Object.create(this);
    };
    return Person;
}());
var Department = /** @class */ (function () {
    function Department(name) {
        this.name = name;
    }
    return Department;
}());
var Address = /** @class */ (function () {
    function Address(country, city, description) {
        this.country = country;
        this.city = city;
        this.description = description;
    }
    return Address;
}());
var person = new Person("Emre Can", "UĞURLU", 23, new Department("Yapay Zeka"), new Address("Türkiye", "Hatay", "Yayladağı"), true);
var person2 = person.clone();
console.log(person2.name);
debugger;
