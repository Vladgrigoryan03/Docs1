using System;
class MovieTicket{

    public string _movieName;

    public int[] _seatNumber;

    public bool _isBooked;


    public MovieTicket(string movieName){
        _movieName = movieName;
        _seatNumber = new int [5] {1,2,3,4,5}; 
        _isBooked = false;
    }
    public void ShowInfo(){
         
        while(true){
            Console.WriteLine("********************");
        for(int i = 0; i < 5; ++i){
            if(_seatNumber[i] != -1){
                
                Console.WriteLine($"{_seatNumber[i]}");
            }
        }
        Console.WriteLine("********************");
        int seats;
       
        Console.WriteLine("Choose your seats or you don't want touch 0");
        seats = int.Parse(Console.ReadLine());
        if(seats == 0){
            break;
        }
        if(_seatNumber[seats - 1] == -1){
            Console.WriteLine("//\nIsn't available seat\n//");
        }
        
        _seatNumber[seats - 1] = -1;
        }
        for(int i = 0; i < 5; ++i){
            if(_seatNumber[i] != -1){
                _isBooked = false;
                return;
            }
            
        }
        _isBooked = true;
       
    }
} 

    class Program {
        static double sum = 0;
        private static void Menu_theatr(){
            Console.WriteLine("This is our menu");
            Console.WriteLine("////////////////////////////////\n");
            Console.WriteLine("Coca cola/Fanta/Sprite - 600amd");
            Console.WriteLine("Popcorn - 1500amd");
            Console.WriteLine("Natural juice - 800amd");
            Console.WriteLine("Khabab )) - 2000amd");
            Console.WriteLine("Cocktail - 2200amd");
            Console.WriteLine("////////////////////////////////\n");

            string c;
            int qanak;
            while(true){
                c = Console.ReadLine();
                if(c == "verj"){
                    break;
                }
                if(c == "Coca cola" || c == "Fanta" || c == "Sprite"){
                    Console.WriteLine("How many");
                    qanak = int.Parse(Console.ReadLine());
                    sum += qanak * 600;
                    Console.WriteLine("What else would you like?");
                }
                if(c == "Popcorn"){
                    Console.WriteLine("How many");
                    qanak = int.Parse(Console.ReadLine());
                    sum += qanak * 1500;
                    Console.WriteLine("What else would you like?");
                }
                if(c == "Natural juice"){
                    Console.WriteLine("How many");
                    qanak = int.Parse(Console.ReadLine());
                    sum += qanak * 800;
                    Console.WriteLine("What else would you like?");
                }
                if(c == "Khabab"){
                    Console.WriteLine("How many");
                    qanak = int.Parse(Console.ReadLine());
                    sum += qanak * 2000;
                    Console.WriteLine("What else would you like?");
                }
                if(c == "Cocktail"){
                    Console.WriteLine("How many");
                    qanak = int.Parse(Console.ReadLine());
                    sum += qanak * 2200;
                    Console.WriteLine("What else would you like?");
                }
            }

        }
        static void Main(string[] args) {

            
            MovieTicket[] ticket = new MovieTicket[3];
            ticket[0] = new MovieTicket("Bari or 2");

            ticket[1] = new MovieTicket("Soprano");

            ticket[2] = new MovieTicket("Goodfellas 1990");
        
        Console.WriteLine("Choose your favorite film");
        for(int i = 0; i < 3; ++i){
            Console.WriteLine($"{i+1}){ticket[i]._movieName}");
        }
        int num = int.Parse(Console.ReadLine());
        if(num == 1){
            if(!ticket[0]._isBooked){
            ticket[0].ShowInfo();
            }else{
                Console.WriteLine("There is no available seats");
            }
        }
        else if(num == 2){
            if(!ticket[1]._isBooked){
            ticket[1].ShowInfo();
            }
            else {
                Console.WriteLine("There is no available seats");
            }
        }
        else{
            if(!ticket[2]._isBooked){
            ticket[2].ShowInfo();
            }
            else {
                Console.WriteLine("There is no available seats");
            }
        }
        int count = 0;
        for(int i = 0; i < 5; ++i){
            if(ticket[num - 1]._seatNumber[i] == -1){
                ++count;
            }
        }
        
        Console.WriteLine("12:00 - 16:00 price is 2500");
        Console.WriteLine("16:00 - 20:00 price is 4000");
        Console.WriteLine("20:00 - 24:00 price is 6500");
        Console.WriteLine("////////////////////////////");
        Console.WriteLine("What time do you want to book");
        string mystring = Console.ReadLine();
        if (mystring == "12:00 - 16:00"){
            sum += count * 2500;
        }
        else if (mystring == "16:00 - 20:00"){
            sum += count * 4000;
        }
        else if(mystring == "20:00 - 24:00"){
            sum += count * 6500;
        }
        else {
            Console.WriteLine("Not available time");
        }
        Menu_theatr();
        Console.WriteLine("Cash or by cart?(By card receive a 2% discount)");
        string a = Console.ReadLine();
        if(a == "Cash"){
            Console.WriteLine($"Your sum is {sum}");
            Console.WriteLine("Good view");

        }
        if(a == "Card"){
            sum *= 0.98;
            Console.WriteLine($"Your sum is {sum}");
            Console.WriteLine("Good view");
        }
    }
}
