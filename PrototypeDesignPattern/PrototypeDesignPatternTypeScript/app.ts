
interface IPersonClonable {
    clone() : Person;
}

class Person  implements IPersonClonable{
    constructor(
        name : string,
        surname : string,
        age : number,
        department : Department,
        address : Address,
        isPremium : boolean
    ) {
        this.name = name
        this.surname = surname
        this.age = age
        this.department = department
        this.address = address
        this.isPremium = isPremium
        console.log("Person oluşturuldu.")
    }

    name : string
    surname : string
    age : number
    department : Department
    address : Address
    isPremium : boolean

    clone() : Person {
        return Object.create(this) as Person
    }
}

class Department {
    constructor(name : string) {
        this.name = name
    }
    name : string
}

class Address {
    constructor(country : string, city : string, description: string) {
        this.country = country
        this.city = city
        this.description = description
    }
    country : string
    city : string
    description : string
}

var person : Person = new Person("Emre Can","UĞURLU",23,new Department("Yapay Zeka"),new Address("Türkiye","Hatay","Yayladağı"),true)

const person2 : Person = person.clone();
console.log(person2.name)
debugger