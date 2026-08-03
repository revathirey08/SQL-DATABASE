using System;
class Program
{
    static void Main()
    {
        Dog d = new Dog();
        d.Eat();
        d.Bark();
    }
}
class Animal

{
    public void Eat()
    {
        Console.WriteLine("Animal is Eating");
    }
}
    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Dog is Barking");
        }
    }

