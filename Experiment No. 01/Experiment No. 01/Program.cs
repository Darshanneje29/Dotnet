using System;

namespace CSharpBasicDemo
{
    class Program
    {
        static void Main(string[] args)
        {
           

            // Variables and Data Types
            int num1, num2;
            double result;
            string name;
            bool isGreater;

            // User Input
            Console.Write("Enter your name: ");
            name = Console.ReadLine();

            // Type Casting
            Console.Write("Enter first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());   

            Console.Write("Enter second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            // Operators and Math
            int add = num1 + num2;
            int sub = num1 - num2;
            int mul = num1 * num2;

            Console.WriteLine("\nHello " + name);
            Console.WriteLine("Addition = " + add);
            Console.WriteLine("Subtraction = " + sub);
            Console.WriteLine("Multiplication = " + mul);

            if (num2 != 0)
            {
                result = (double)num1 / num2;
                Console.WriteLine("Division = " + result);
            }
            else
            {
                Console.WriteLine("Division by zero not allowed");
            }

            // Boolean
            isGreater = num1 > num2;
            Console.WriteLine("Is first number greater? " + isGreater);

            // Math class
            Console.WriteLine("Maximum number = " + Math.Max(num1, num2));
            Console.WriteLine("Square root of first number = " + Math.Sqrt(num1));

            // Strings
            Console.WriteLine("Name Length = " + name.Length);
            Console.WriteLine("Uppercase Name = " + name.ToUpper());

            // If...Else
            if (num1 % 2 == 0)
            {
                Console.WriteLine("First number is Even");
            }
            else
            {
                Console.WriteLine("First number is Odd");
            }

            // Switch Statement
            Console.Write("\nChoose operation (1-Add,2-Sub,3-Mul,4-Div): ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Result = " + add);
                    break;
                case 2:
                    Console.WriteLine("Result = " + sub);
                    break;
                case 3:
                    Console.WriteLine("Result = " + mul);
                    break;
                case 4:
                    if (num2 != 0)
                        Console.WriteLine("Result = " + (num1 / num2));
                    else
                        Console.WriteLine("Cannot divide by zero");
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }

            // Arrays
            int[] numbers = { 10, 20, 30, 40, 50 };

            Console.WriteLine("\nArray Elements:");
            for (int i = 0; i < numbers.Length; i++)   // For Loop
            {
                Console.WriteLine(numbers[i]);
            }

            // While Loop
            int count = 0;
            Console.WriteLine("\nWhile Loop Example:");
            while (count < 5)
            {
                count++;

                if (count == 3)
                    continue;   // Continue example

                if (count == 5)
                    break;      // Break example

                Console.WriteLine("Count = " + count);
            }

            Console.WriteLine("\nProgram Finished.");
            Console.ReadKey();
        }
    }
}