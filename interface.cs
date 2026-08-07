using System;

class Program
{
    static void Main()
    {
        Dog d = new Dog();

        d.Sound();
    }
}

interface IAnimal
{
    void Sound();
}

class Dog : IAnimal
{
    public void Sound()
    {
        Console.WriteLine("Dog is Barking");
    }
}
