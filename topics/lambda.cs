// This code is AI generated
using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        // Lambda function for sum
        Func<int, int, int> add = (a, b) => a + b;
        int sum = add(5, 3);  // sum will be 8
        Console.WriteLine("Sum: " + sum);

        // LINQ example with lambda expression
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        List<int> largeNumbers = numbers.Where(n => n > 5).ToList();
        Console.WriteLine("Numbers greater than 5: " + string.Join(", ", largeNumbers));
    }
}

// FAQs:
// What is a lambda expression in C#? 
// A lambda expression is a concise way to write anonymous methods (methods without a name) in C#. It’s a function without a name that calculates and returns a single result.

// How is a lambda expression used in the code?
// In the code, a lambda expression is used in two places:
// As a Func<int, int, int> delegate to create a function add that adds two integers.
// In a LINQ query to filter a list of numbers to only include numbers greater than 5.

// What does the ‘=>’ operator do in a lambda expression?
// The => operator in a lambda expression is called the lambda operator. It separates the parameters on the left from the expression or statement block on the right.

// Can a lambda expression have multiple parameters?
// Yes, a lambda expression can have multiple parameters. In the add function in the code, the lambda expression has two parameters, a and b.

// Can a lambda expression be used with LINQ?
// Yes, lambda expressions are often used with LINQ (Language Integrated Query) to write query expressions. In the code, a lambda expression is used with the Where method to filter a list of numbers.