using System;

namespace SOLIDPrinciplesDemo
{

    // 1. Single Responsibility Principle 
    class Student
    {
        public string Name { get; set; } = "";
        public int RollNo { get; set; }
    }

    class StudentPrinter
    {
        public void Print(Student s)
        {
            Console.WriteLine("Student Name: " + s.Name);
            Console.WriteLine("Roll No: " + s.RollNo);
        }
    }

    // 2. Open/Closed Principle 
    abstract class Shape
    {
        public abstract double Area();
    }

    class Rectangle : Shape
    {
        public double width = 5;
        public double height = 4;

        public override double Area()
        {
            return width * height;
        }
    }

    class Circle : Shape
    {
        public double radius = 3;

        public override double Area()
        {
            return Math.PI * radius * radius;
        }
    }

    // 3. Liskov Substitution Principle
    class Bird
    {
        public virtual void Fly()
        {
            Console.WriteLine("Bird is flying");
        }
    }

    class Sparrow : Bird
    {
        public override void Fly()
        {
            Console.WriteLine("Sparrow flies in the sky");
        }
    }

    // 4. Interface Segregation Principle
    interface IPrint
    {
        void Print();
    }

    interface IScan
    {
        void Scan();
    }

    class Printer : IPrint
    {
        public void Print()
        {
            Console.WriteLine("Printing document...");
        }
    }

    class Scanner : IScan
    {
        public void Scan()
        {
            Console.WriteLine("Scanning document...");
        }
    }

    // 5. Dependency Inversion Principle
    interface IMessage
    {
        void Send();
    }

    class Email : IMessage
    {
        public void Send()
        {
            Console.WriteLine("Sending Email Message");
        }
    }

    class Notification
    {
        private IMessage message;

        public Notification(IMessage msg)
        {
            message = msg;
        }

        public void Notify()
        {
            message.Send();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== SOLID Principles Demonstration =====\n");

            // SRP Example
            Student s = new Student { Name = "Rahul", RollNo = 101 };
            StudentPrinter sp = new StudentPrinter();
            sp.Print(s);

            Console.WriteLine();

            // OCP Example
            Shape rect = new Rectangle();
            Shape circ = new Circle();
            Console.WriteLine("Rectangle Area: " + rect.Area());
            Console.WriteLine("Circle Area: " + circ.Area());

            Console.WriteLine();

            // LSP Example
            Bird b = new Sparrow();
            b.Fly();

            Console.WriteLine();

            // ISP Example
            Printer p = new Printer();
            p.Print();

            Scanner sc = new Scanner();
            sc.Scan();

            Console.WriteLine();

            // DIP Example
            IMessage email = new Email();
            Notification notify = new Notification(email);
            notify.Notify();

            Console.ReadKey();
        }
    }
}