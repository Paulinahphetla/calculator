using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    static void Main(string[] args)
    {
        // It will loop until the user chooses No


        do
        {
            Console.WriteLine("FANTASTIC 3 C# CALCULATOR");

            //declartions
            double num1, num2, results;

            // Ask the user to enter num1
            Console.WriteLine("Enter first number:");
            //validation
            while (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Invalid input. Please enter a valid number:");
            }

            // Ask the user to enter the operator
            Console.WriteLine("Enter operator (+, -, *, /):");
            string op = Console.ReadLine();

            // Ask the user to enter num2
            Console.WriteLine("Enter second number:");
            //validation
            while (!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Invalid input. Please enter a valid number:");
            }

            // Calculate the result based on the chosen operator
            switch (op)
            {
                case "+":
                    results = num1 + num2;
                    Console.WriteLine($"Your result: {num1} + {num2} = {results}");
                    break;
                case "-":
                    results = num1 - num2;
                    Console.WriteLine($"Your result: {num1} - {num2} = {results}");
                    break;
                case "*":
                    results = num1 * num2;
                    Console.WriteLine($"Your result: {num1} * {num2} = {results}");
                    break;
                case "/":
                    results = num1 / num2;
                    Console.WriteLine($"Your result: {num1} / {num2} = {results}");
                    break;
                default:
                    Console.WriteLine("That was not a valid operator.");
                    break;
            }
            //option to cpntinue using calculator
            Console.WriteLine("Would you like to continue? (Y = yes, N = no):");
        } while (Console.ReadLine().ToUpper() == "Y");

        Console.WriteLine("Goodbye!");
    }
}
