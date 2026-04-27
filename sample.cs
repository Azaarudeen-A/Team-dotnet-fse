using System;

class Program
{
    
static void Main(string[] args){
            Console.WriteLine("Hello, World!");
            Console.WriteLine("This is my first simple C# project.");

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine($"Welcome, {name}!");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

}