using System;

namespace firstCApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Simple Maths";
            Console.WriteLine("Welcome to the Latte Shop! Pay you for coffee");

            double cash = Convert.ToDouble(Console.ReadLine());

            if (cash < 5) 
            {
                double balance = 5 - cash;
                Console.WriteLine("You need $" + balance + " more");
            }
             else if (cash == 5)
            {
               
                Console.WriteLine("Enjoy your coffee");
            }
            else
            {
                double change = cash - 5;
                Console.WriteLine("Your change is $" + change);
            }
            
            
            Console.ReadKey();
        }
    }
}

