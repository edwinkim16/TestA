// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Linq; // Required for LINQ methods like Where

class Calculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Choose an operation (+, -, *, /):");
        string operation = Console.ReadLine();

        double result = 0;

        switch (operation)
        {
            case "+":
                result = Add(num1, num2);
                break;
            case "-":
                result = Subtract(num1, num2);
                break;
            case "*":
                result = Multiply(num1, num2);
                break;
            case "/":
                result = Divide(num1, num2);
                break;
            default:
                Console.WriteLine("Invalid operation");
                return;
        }

        Console.WriteLine($"The result is: {result}");

        Console.WriteLine("Do you want to calculate the average of a list of integers? (yes/no)");
        string response = Console.ReadLine();

        if (response.ToLower() == "yes")
        {
            Console.WriteLine("Enter the integers separated by spaces:");
            string[] input = Console.ReadLine().Split(' ');
            
            // Filter out any empty strings and convert the remaining strings to integers
            int[] numbers = input
                            .Where(s => !string.IsNullOrWhiteSpace(s))
                            .Select(int.Parse)
                            .ToArray();

            double average = CalculateAverage(numbers);
            Console.WriteLine($"The average is: {average}");
        }
    }

    static double Add(double a, double b)
    {
        return a + b;
    }

    static double Subtract(double a, double b)
    {
        return a - b;
    }

    static double Multiply(double a, double b)
    {
        return a * b;
    }

    static double Divide(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Error: Division by zero");
            return 0;
        }
        return a / b;
    }

    static double CalculateAverage(int[] numbers)
    {
        if (numbers.Length == 0)
        {
            return 0;
        }

        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }

        return (double)sum / numbers.Length;
    }
}
