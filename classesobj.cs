using System;

class Student
{
    public string name;
    public int age;

    // Constructor
    public Student(string n, int a)
    {
        name = n;
        age = a;
    }

    // Method
    public void Display()
    {
        Console.WriteLine("Name : " + name);
        Console.WriteLine("Age  : " + age);
    }
}

class Program
{
    static void Main()
    {
        // Object Creation
        Student s1 = new Student("Revathi", 20);

        // Method Call
        s1.Display();
    }
}