using System;

namespace Prov
{
    class Program
    {
        static void Main(string[] args)
        {
            Book b = new Book();

            Console.WriteLine("Skriv namnet på din bok:");
            b.name = Console.ReadLine();

            b.PrintInfo();
           
            Console.ReadLine();

        }
    }

    public class Book 
    {
        Random generator = new Random();

        public int price;
        public string name;
        public int rarity;
        public string category;
        public int actualValue;

        public Book()
        {
            //Här så slumpas helt enkelt vilken rarity boken har och vilket värde boken har. 
            rarity = generator.Next(0,10);
            price = generator.Next(1,1000);
        }

        public void PrintInfo()
        {
            Console.WriteLine();
            System.Console.WriteLine("Name: " + name);
            System.Console.WriteLine("Rarity: " + rarity);
            System.Console.WriteLine("Price: " + price);
        }


    }

    class Customer
    {
        public int item;
    }
}
