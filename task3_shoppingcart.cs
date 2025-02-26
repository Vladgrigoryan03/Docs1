using System;

class Product
{
    private string _productName;

    private double _productPrice;

    private int _productQuantity;

    public Product(string name, double price)
    {
        _productName = name;
        _productPrice = price;
        _productQuantity = 5;
    }
    public string ProductName
    {
        get { return _productName; }
        set { _productName = value; }
    }
    public double ProductPrice
    {
        get { return _productPrice; }
        set { _productPrice = value; }
    }

    public int ProductQuantity
    {
        get { return _productQuantity; }
        set { _productQuantity = value; }
    }

    public double TotalPrice()
    {
        return _productPrice * _productQuantity;
    }
    public void ShowInfo()
    {
        Console.WriteLine($"Product: {_productName}\nPrice: {_productPrice}\nQuanty: {_productQuantity}\n");
    }

    class Program
    {
        static void Main(string[] args)
        {
            Product[] product = new Product[5];
            product[0] = new Product("Bread", 200.00);
            product[1] = new Product("Cheese", 1800.00);
            product[2] = new Product("Juise", 600.00);
            product[3] = new Product("Meet", 3400.00);
            product[4] = new Product("Vodka Belluga Epicure", 16500.00);

            int _allQuantity = 0;
            Console.WriteLine("Barev dzez mer tesakanin e");
            for (int i = 0; i < product.Length; ++i)
            {
                product[i].ShowInfo();
            }
            string? answer;
            double sum = 0;
            while (true)
            {
                Console.WriteLine("Press '+' to choose a product\nPress 'X' to exit");
                answer = Console.ReadLine();
                if (answer == "+")
                {
                    Console.WriteLine("Choose product");
                    string? name = Console.ReadLine();
                    Console.WriteLine("Choose quantity");
                    int qanak = int.Parse(Console.ReadLine());
                    _allQuantity += qanak;
                    for (int i = 0; i < 5; ++i)
                    {
                        if (name == product[i].ProductName)
                        {
                            product[i].ProductQuantity = qanak;
                            sum += product[i].TotalPrice();
                            break;
                        }
                    }

                }
                else if (answer == "X")
                {
                    break;
                }
            }
            if (_allQuantity >= 5)
            {
                sum *= 0.9;
            }
            Console.WriteLine($"The total price is {sum}");
        }

    }
}