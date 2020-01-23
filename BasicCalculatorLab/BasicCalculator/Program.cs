using System;

namespace BasicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** BASIC CALCULATOR ***");

            Console.WriteLine("Enter the first number");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            // int.Parse will take a string data type and convert it to an int data type
            var firstNumber = int.Parse(Console.ReadLine());
            int v = firstNumber * secondNumber;
            int product = v;
            Console.WriteLine("The answer is " + product);
            Console.WriteLine("Good job!");
        }
    }
}
