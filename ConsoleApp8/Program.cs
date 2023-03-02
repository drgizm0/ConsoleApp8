// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter two whole numbers to add:");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int result1 = Add(a, b);
        Console.WriteLine("Result 1: " + result1);

        Console.WriteLine("Enter two doubles to add:");
        double c = double.Parse(Console.ReadLine());
        double d = double.Parse(Console.ReadLine());
        double result2 = Add(c, d);
        Console.WriteLine("Result 2: " + result2);

        Console.WriteLine("Enter first name:");
        string e = Console.ReadLine();
        Console.WriteLine("Enter Surname:");
        string f = Console.ReadLine();
        string result3 = Add(e, f);
        Console.WriteLine("Result 3: " + result3);

        Console.ReadKey();
    }

    static int Add(int a, int b)
    {
        return a + b;
    }

    static double Add(double c, double d)
    {
        return c + d;
    }

    static string Add(string e, string f)
    {
        return e + f;
    }
}


