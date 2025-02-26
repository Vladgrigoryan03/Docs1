using System;

class Car{

    private string _carModel;
    private int _carYear;
    public bool _carIsRented;

    public Car(string model, int year){
        _carModel = model;
        _carYear = year;
        _carIsRented = false;
    }
    public string CarModel{
        get{
            return _carModel;
        }
        set {
            _carModel = value;
            }
        }
    private int CarYear{
        get{
            return _carYear;
        }
        set { 
            _carYear = value;
            }
        }
public void RentCar(){
    this._carIsRented = true;
}
public void ReturnCar(){
    this._carIsRented = false;
}
}

class Program{
    public static void Main(string[] args){
        Car[] car = new Car[5];
        car[0] = new Car("Tesla",2014);
        car[1] = new Car("Cls", 2016);
        car[2] = new Car("Kadilak", 1999);
        car[3] = new Car("Opel", 2004);
        car[4] = new Car("Mustang", 2012);

        string? command;
        Console.WriteLine("Choose rent or return");
        command = Console.ReadLine();
        
        for(int i = 0; i < 5; ++i){
            Console.WriteLine($"{car[i].CarModel}");
        }
        if(command == "rent"){
        string? c = "";
        Console.WriteLine("Choose car");
        c = Console.ReadLine();
        for(int i = 0; i < 5; ++i){
            if(c == car[i].CarModel){
                if(!car[i]._carIsRented){
                car[i].RentCar();
                break;
                }
                else {
                    Console.WriteLine("Not allowed");
                    break;
                }
            }
        }
        }
        else if(command == "return"){
            Console.WriteLine("Choose car");
            string? c = "";
            c = Console.ReadLine();
            for(int i = 0; i < 5; ++i){
            if(c == car[i].CarModel){
                if(car[i]._carIsRented){
                car[i].ReturnCar();
                break;
                }
                else {
                    Console.WriteLine("Illegal action");
                    break;
                }
            }
        }
            
    }
}
}