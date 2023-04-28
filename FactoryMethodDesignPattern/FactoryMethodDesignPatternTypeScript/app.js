var ABank = /** @class */ (function () {
    function ABank() {
        console.log("A bankas�ndan nesne olu�turuldu.");
    }
    return ABank;
}());
var BBank = /** @class */ (function () {
    function BBank() {
        console.log("B bankas�ndan nesne olu�turuldu.");
    }
    return BBank;
}());
var CBank = /** @class */ (function () {
    function CBank() {
        console.log("C bankas�ndan nesne olu�turuldu.");
    }
    return CBank;
}());
var ABankFactory = /** @class */ (function () {
    function ABankFactory() {
    }
    ABankFactory.prototype.getInstance = function () {
        return new ABank();
    };
    return ABankFactory;
}());
var BBankFactory = /** @class */ (function () {
    function BBankFactory() {
    }
    BBankFactory.prototype.getInstance = function () {
        return new BBank();
    };
    return BBankFactory;
}());
var CBankFactory = /** @class */ (function () {
    function CBankFactory() {
    }
    CBankFactory.prototype.getInstance = function () {
        return new CBank();
    };
    return CBankFactory;
}());
var BankType;
(function (BankType) {
    BankType[BankType["ABank"] = 0] = "ABank";
    BankType[BankType["BBank"] = 1] = "BBank";
    BankType[BankType["CBank"] = 2] = "CBank";
})(BankType || (BankType = {}));
var CreationalBank = /** @class */ (function () {
    function CreationalBank() {
    }
    CreationalBank.getInstance = function (bankType) {
        var instance;
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
    };
    return CreationalBank;
}());
var a = CreationalBank.getInstance(BankType.ABank);
var b = CreationalBank.getInstance(BankType.BBank);
var c = CreationalBank.getInstance(BankType.CBank);
