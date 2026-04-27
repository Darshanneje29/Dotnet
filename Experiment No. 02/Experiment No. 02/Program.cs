using System;

// Abstraction (Abstract Class)
abstract class Person
{
    // Encapsulation using private field
    private string name;

    // Property (Getter and Setter)
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    // Abstract method (Abstraction)
    public abstract void DisplayRole();
}

// Inheritance
class Student : Person
{
    // Class Members
    public int rollNo;
    public string course;

    // Constructor
    public Student(int r, string c, string n)
    {
        rollNo = r;
        course = c;
        Name = n;
    }

    // Polymorphism (Method Override)
    public override void DisplayRole()
    {
        Console.WriteLine("Role: Student");
    }

    public void ShowDetails()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Roll No: " + rollNo);
        Console.WriteLine("Course: " + course);
    }
}

// Another derived class
class Teacher : Person
{
    public string subject;

    // Constructor
    public Teacher(string s, string n)
    {
        subject = s;
        Name = n;
    }

    // Polymorphism
    public override void DisplayRole()
    {
        Console.WriteLine("Role: Teacher");
    }

    public void ShowDetails()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Subject: " + subject);
    }
}

class Program
{
    static void Main(string[] args)
    {
      

        // Creating Student Object
        Student s1 = new Student(101, "Computer Science", "Rahul");
        s1.DisplayRole();
        s1.ShowDetails();

        Console.WriteLine();

        // Creating Teacher Object
        Teacher t1 = new Teacher("Programming", "Dr. Sharma");
        t1.DisplayRole();
        t1.ShowDetails();

        Console.ReadKey();
    }
}