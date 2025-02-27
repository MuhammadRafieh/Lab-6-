using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> groceries = new List<string>
        {    "jelly", 
            "Milk",
            "Eggs",
            "Bread",
            "Chicken",
            "Apples"
        };

        Console.WriteLine("Grocery List:");
        foreach (var item in groceries)
        {
            Console.WriteLine("- " + item);
        }
    }
} 
