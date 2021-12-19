// bank , withdrawl ,deposit

interface IBank{
    withdraw(value:number);
    deposit(value:number);
}

class Bank implements IBank{
    total:number=25000;
    withdraw(withdrawvalue:number)
    {
        this.total=this.total-withdrawvalue;
    }
    deposit(despositvalue:number)
    {
        this.total=this.total+despositvalue;
    }
}

var bank = new Bank();
bank.deposit(10000);
bank.withdraw(5000);

console.log(bank.total);