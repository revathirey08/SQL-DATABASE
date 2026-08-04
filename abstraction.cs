using System;

class See
{
    static void Main()
    {
        Dog d = new Dog();
        d.Sound();
    }
}
abstract class Animal
{
    public abstract void Sound();
}
class Dog : Animal
{
    public override void Sound()
    {
        Console.WriteLine("Dog is barking");
    }
}
