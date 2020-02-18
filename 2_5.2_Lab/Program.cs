using System;

namespace _2_5._2_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int n1, n2, n3;
            Console.WriteLine("Enter a value for the first number:");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a value for the second number:");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a value for the third number:");
            n3 = Convert.ToInt32(Console.ReadLine());

            int result = n1 * n2 *n3;
            Console.WriteLine("Multiplication of 3 Numbers is " + result);

        }
    }
}
