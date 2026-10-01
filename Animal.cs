using System;
Animal[] animals =
{
    new Animal(),
    new Dog(),
    new Cat()
};
foreach (Animal animal in animals)
{
    animal.Speak();
}
class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("Some sound");
    }
}
class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Woof");
    }
}
class Cat : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Meow");
    }
}
class Cow : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Moo");
    }
}