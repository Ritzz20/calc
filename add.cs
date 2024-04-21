using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers to add:");

            // Read the first number from the user
            Console.Write("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            // Read the second number from the user
            Console.Write("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            // Calculate the sum
            int sum = num1 + num2;

            // Display the result
            Console.WriteLine($"The sum of {num1} and {num2} is: {sum}");
        }
    }
}
