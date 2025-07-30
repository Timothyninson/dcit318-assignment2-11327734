﻿using System;

namespace InheritanceAndOverriding
{
    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic sound");
        }
    }

    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Animal();
            Animal d = new Dog();
            Animal c = new Cat();

            a.MakeSound();
            d.MakeSound();
            c.MakeSound();
        }
    }
}
