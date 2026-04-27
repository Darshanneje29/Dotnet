using System;

namespace DelegateLambdaDemo
{
    // Delegate declaration
    public delegate int Operation(int a, int b);

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Delegates and Lambda Expressions");

            // Delegate using normal method
            Operation add = Add;
            Console.WriteLine("Addition: " + add(10, 5));

            // Delegate using Anonymous Method
            Operation subtract = delegate (int x, int y)
            {
                return x - y;
            };
            Console.WriteLine("Subtraction: " + subtract(10, 5));

            // Delegate using Lambda Expression
            Operation multiply = (x, y) => x * y;
            Console.WriteLine("Multiplication: " + multiply(10, 5));

            Console.ReadKey();
        }

        // Method for delegate
        public static int Add(int a, int b)
        {
            return a + b;
        }
    }
}