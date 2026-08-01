using System;

class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student();

        s1.SetName("Revathi");

        Console.WriteLine(s1.GetName());
    }
}

class Student
{
    private string name = "";

    public void SetName(string n)
    {
        name = n;
    }

    public string GetName()
    {
        return name;
    }
}