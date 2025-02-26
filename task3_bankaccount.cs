using System;

class BankAcc{
    public string AccNum{get; private set;}
    public double Balance{get; private set;}

    public BankAcc(string accNum, double balance){
        this.AccNum = accNum;
        this.Balance = balance; 
    }
    public override string ToString(){
        return $"Account: {AccNum} and Balance: {Balance}";
    }   
    public override bool Equals(object obj){
        if(obj == null){
            return false;
        }
        if(obj is BankAcc other){
            return this.AccNum == other.AccNum;
        }
        return false;
    }
    public override int GetHashCode(){
        return AccNum.GetHashCode() ^ 5;
    }
    public static BankAcc operator +(BankAcc acc, double amount){
        if(amount < 0){
            return acc;
        }
        acc.Balance += amount;
        return acc;
    }
    public static BankAcc operator -(BankAcc acc, double amount){
        if(amount < 0){
            return acc;
        }
        if(amount > acc.Balance){
            Console.WriteLine("Chi bavararum");
        }
        acc.Balance -= amount;
        return acc;
    }

    public static bool operator >(BankAcc acc1, BankAcc acc2){
        return acc1.Balance > acc2.Balance;
    }

    public static bool operator <(BankAcc acc1, BankAcc acc2){
        return acc1.Balance < acc2.Balance;
    }

    public static bool operator >=(BankAcc acc1, BankAcc acc2){
        return acc1.Balance >= acc2.Balance;
    }

    public static bool operator <=(BankAcc acc1, BankAcc acc2){
        return acc1.Balance <= acc2.Balance;
    }
}
    public class Program{
        public static void Main(string[] args){
            BankAcc account1 = new BankAcc("Vlad", 15000.00);
            BankAcc account2 = new BankAcc("Narek", 100000.00);
        Console.WriteLine(account1);
        Console.WriteLine(account2);

        account1 -= 15000.00;
        Console.WriteLine(account1);

        account2 += 15000.00;
        Console.WriteLine(account2);
        }
    }


