
interface IBank {

}


class ABank implements IBank {
    constructor() {
        console.log("A bankasýndan nesne oluþturuldu.");
    }
}


class BBank implements IBank {
    constructor() {
        console.log("B bankasýndan nesne oluþturuldu.");
    }
}


class CBank implements IBank {
    constructor() {
        console.log("C bankasýndan nesne oluþturuldu.");
    }
}


interface IBankFactory {
    getInstance(): IBank;
}


class ABankFactory implements IBankFactory {
    public getInstance(): IBank {
        return new ABank();
    }
}

class BBankFactory implements IBankFactory {
    public getInstance(): IBank {
        return new BBank();
    }
}


class CBankFactory implements IBankFactory {
    public getInstance(): IBank {
        return new CBank();
    }
}

enum BankType {
    ABank,
    BBank,
    CBank
} 


class CreationalBank {
    
    public static getInstance(bankType: BankType): IBank{
        let instance: IBankFactory;
        switch (bankType) {
            case BankType.ABank: {
                instance = new ABankFactory();
                break;
            }
            case BankType.BBank: {
                instance = new BBankFactory();
                break;
            }
            case BankType.CBank: {
                instance = new CBankFactory();
                break;
            }
        }
        return instance.getInstance();
    }
}


let a = CreationalBank.getInstance(BankType.ABank);
let b = CreationalBank.getInstance(BankType.BBank);
let c = CreationalBank.getInstance(BankType.CBank);