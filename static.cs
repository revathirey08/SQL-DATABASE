using System;

class Program
{
    static void Main()
    {
        Student.College();

        Console.WriteLine(Student.CollegeName);
    }
}

class Student
{
    public static string CollegeName = "Mailam Engineering College";

    public static void College()
    {
        Console.WriteLine("Welcome to College");
    }
}