using System;

public class BankAccount{
    public string name;
    public string hashiv;
    public int balance;

    public BankAccount(){
        Console.WriteLine("Enter your name");
        this.name = Console.ReadLine();
        Console.WriteLine("Enter your numbers");
        this.hashiv = Console.ReadLine();
        this.balance = 10000;

    }
}
class Program{
    static void Main(string[] args){
        BankAccount account = new BankAccount();
        Console.WriteLine("Choose input or output");
        string? com = Console.ReadLine();
        if(com ==  "input"){
            Console.WriteLine("Enter sum");
            int num = int.Parse(Console.ReadLine());
            account.balance += num;
            Console.WriteLine($"Hashvi mnacordy kazmum e: {account.balance}");
        }
        else if(com == "output"){
            Console.WriteLine("Enter sum");
            int num = int.Parse(Console.ReadLine());
            if(num > account.balance){
                Console.WriteLine("Balance error");
            }
            else {
                account.balance -= num;
                Console.WriteLine($"Hashvi mnacordy kazmum e: {account.balance}");
            }
        }
        else {
            Console.WriteLine("Invalid command");

        }
    }

}
 