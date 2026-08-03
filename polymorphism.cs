using System;
class Program
{
    static void Main()
    {
        Maths m = new Maths();
        m.Add(10, 20);
        m.Add(20.5, 30.9);

    }
}
class Maths

{
    public void Add(int a, int b)
    {
        Console.WriteLine(a+b);
    }
    public void Add(double a, double b)
    {
        Console.WriteLine(a + b);
    }
}

