using System;

namespace quadratic
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, x1, x2;

            Console.WriteLine("What is a?");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("What is b?");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("What is c?");
            c = double.Parse(Console.ReadLine());

            x1 = ((-b) + Math.Sqrt((b * b) - 4 * a * c)) / (2 * a);
            x2 = ((-b) - Math.Sqrt((b * b) - 4 * a * c)) / (2 * a);

           Console.WriteLine("The answer is: {0}, {1}", x1, x2);
        }
    }
}