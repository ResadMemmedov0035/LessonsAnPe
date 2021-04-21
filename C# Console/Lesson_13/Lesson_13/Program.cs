using System;

namespace Lesson_13
{
    class BaseClass
    {
        private int PrivateProp { get; set; }
        protected int ProtectedProp { get; set; }
        public int PublicProp { get; set; }

        public BaseClass()
        {
            PrivateProp = 10;
            ProtectedProp = 10;
            PublicProp = 10;
        }
    }

    class DerivedClass : BaseClass
    {
        public DerivedClass()
        {
            // PrivateProp = 10; // unaccesable
            ProtectedProp = 10;
            PublicProp = 10;
        }
    }

    abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Sound()
        {
            Console.WriteLine("Default animal sound");
        }

        //public virtual void VSound()
        //{
        //    Console.WriteLine("Default animal sound");
        //}

        public abstract void ASound();

        public override string ToString()
        {
            return $"{Name} {Age}";
        }
    }

    sealed class Cat : Animal
    {
        public string Cins { get; set; }

        public Cat(string name, int age, string cins) : base(name, age)
        {
            Cins = cins;
        }

        public new void Sound()
        {
            Console.WriteLine("Miav");
        }

        public override void ASound()
        {
            Console.WriteLine("Miavvv");
        }

        public override string ToString()
        {
            return base.ToString() + $" {Cins}";
        }
    }

    //class Dog : Animal
    //{

    //}

    class Program
    {
        static void Main(string[] args)
        {


            Animal cat = new Cat("Mestan", 2, "Kuce");
            cat.ASound();


            //Animal cat = new Cat("Mestan", 2, "Kuce");
            //Console.WriteLine(cat); // cat.ToString() -- cagrilir


            //Cat c = new Animal();

            //Animal cat = new Cat();
            //cat.Sound();
            //Cat cat1 = new Cat();
            //cat1.Sound();

            //Animal cat2 = new Cat();
            //cat2.VSound();
            //Cat cat3 = new Cat();
            //cat3.VSound();


            //Dog dog = new Dog();
            //dog.Sound();


            //object obj = "Hello";
            //object obj1 = 14;
            //object obj2 = new Dog();

            //DerivedClass derived = new DerivedClass();
            //// derived.PrivateProp = 10; // unaccesable
            //// derived.ProtectedProp = 10; // unaccesable
            //derived.PublicProp = 10;
        }
    }
}
