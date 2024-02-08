using System;
namespace Lynmj;

    internal class Program
    {
        static void Main(string[] args) {
            String name;
            int enrolled;
            double price;


            Console.Write("Enter your name: ");
            name = Console.ReadLine();

            Console.Write("Enter the total of your enrolled courses: ");
            enrolled = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the price of your favorite book: ");
            price = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Name: " + name);
            Console.ReadKey();
            Console.WriteLine("Total enrolled courses: " + enrolled);
            Console.ReadKey();
            Console.WriteLine("Price of my favorite book: " + price);
            Console.ReadKey();
            Console.WriteLine("\nPress any key to exit. . .");
            Console.ReadKey();
            

        }
    }
}