using System;

public interface IAnimal
{
    void MakeSound();
}

public class Dog : IAnimal
{
    public void MakeSound()
    {
        Console.WriteLine("Woof!");
    }
}

public class Cat : IAnimal
{
    public void MakeSound()
    {
        Console.WriteLine("Meow!");
    }
}

public class Program
{
    public static void AnimalSound(IAnimal animal)
    {
        animal.MakeSound();
    }

    public static void Main()
    {
        IAnimal dog = new Dog();
        IAnimal cat = new Cat();

        AnimalSound(dog); // Woof!
        AnimalSound(cat); // Meow!
    }
}
