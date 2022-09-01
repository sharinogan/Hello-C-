using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string user = "Voragun";
            Console.WriteLine($"Hello, {user}");

            string projectName = "First experience";
            Console.Write($"This is {projectName} Program\n"); // string interpolation

            int first = 10;
            int second = 20;
            Console.WriteLine(first + second);

            int sum = 7 + 5;
            int difference = 7 - 5;
            int product = 7 * 5;
            int quotient = 7 / 5;

            Console.WriteLine("Sum : " + sum);
            Console.WriteLine("Difference : " + difference);
            Console.WriteLine("Product : " + product);
            Console.WriteLine("Quotient : " + quotient);
        }
    }
}
