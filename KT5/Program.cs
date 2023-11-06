using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Channels;

namespace ConsoleApplication1
{
    public interface IAnimal 
    {
        string Name { get; }
        void MakeSound();
    }

    class Dog : IAnimal
    {
        private string name = "Dog";
        string IAnimal.Name { get => name; }
        void IAnimal.MakeSound() => Console.WriteLine("dog sound");
    }

    class Cat : IAnimal
    {
        private string name = "Cat";
        string IAnimal.Name { get => name; }

        void IAnimal.MakeSound() => Console.WriteLine("cat sound");
    }

    class Program 
    {
        static void Main(string[] args) 
        {
            IAnimal dog = new Dog();
            IAnimal cat = new Cat();
            
            string animal = dog.Name;
            string animal2 = cat.Name;

            Console.WriteLine(animal);
            ((IAnimal)dog).MakeSound();
            Console.WriteLine(animal2);
            ((IAnimal)cat).MakeSound();

        }
    }
}