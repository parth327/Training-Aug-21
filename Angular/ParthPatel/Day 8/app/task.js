// bank , withdrawl ,deposit
var Bank = /** @class */ (function () {
    function Bank() {
        this.total = 25000;
    }
    Bank.prototype.withdraw = function (withdrawvalue) {
        this.total = this.total - withdrawvalue;
    };
    Bank.prototype.deposit = function (despositvalue) {
        this.total = this.total + despositvalue;
    };
    return Bank;
}());
var bank = new Bank();
bank.deposit(10000);
bank.withdraw(5000);
console.log(bank.total);
