using System;
using TestLib;

namespace Lesson_15
{
    interface ITest
    {
        void Foo();
    }

    class Test : ITest
    {
        public void Foo()
        {
            Console.WriteLine("I am Foo!");
        }
    }

    class Person
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public override int GetHashCode()
        {
            return Name.GetHashCode() - Surname.GetHashCode() + Age;
        }

        public override bool Equals(object obj)
        {
            if (obj is Person other)
            { 
                return Name == other.Name && Age == other.Age;
                //return other.GetHashCode() == GetHashCode();
            }
            return false;

            //var other = (obj as Person);
            //if (other != null)
            //{
            //    return Name == other.Name && Age == other.Age;
            //}
            //return false;
        }

        public override string ToString()
        {
            return $"{Name}, {Age}";
        }

        public static bool operator ==(Person left, Person right)
        {
            return true;
        }

        public static bool operator !=(Person left, Person right)
        {
            return true;
        }
    }

    class Program
    {
        static bool? Method(object obj)
        {
            string str = obj as string;
            return str?.Contains('d');

            ///

            //string str = obj is string ? ((string)obj) : null;
            //return str?.Contains('d');

            ///

            //if(obj is string)
            //    string str = (string)obj;
            //else 
            //    string = null;

            //return str?.Contains('d');
        }

        static void Main(string[] args)
        {
            string str = "Hello";
            string str1 = "Hello";

            Console.WriteLine(str == str1);

            Console.WriteLine(str.GetHashCode());
            Console.WriteLine(str1.GetHashCode());


            Console.WriteLine(20.GetHashCode());
            Console.WriteLine(23.GetHashCode());


            Person person = new Person { Name = "Resad", Surname = "Memmedov", Age = 17 };
            Person person1 = new Person { Name = "Memmedov", Surname = "Resad", Age = 17 };

            if(person.Equals(person1))
                Console.WriteLine("Same data");
            else
                Console.WriteLine("Nope");

            Console.WriteLine(person.GetHashCode());
            Console.WriteLine(person1.GetHashCode());


            //Person person = new Person { Name = "Resad", Age = 17 };

            //Console.WriteLine(person); // person.ToString()


            //var begin = DateTime.Now;

            //int i = 17;
            //object obj1 = i; // boxing

            //Console.WriteLine(DateTime.Now - begin);

            //var begin = DateTime.Now;

            //string str = "Hello";
            //object obj = str;

            //Console.WriteLine(DateTime.Now - begin);


            //var num = obj1 as int?; // unboxing


            //Method(12);


            //object obj = new object();
            //Console.WriteLine(obj.GetType());
            //obj = 12;
            //Console.WriteLine(obj.GetType());

            //((string)obj).Insert(0, "");



            //ITest test = new Test();
            //Console.WriteLine(test is ITest);


            //object obj = "Hello";
            //bool isString = obj is int;

            //Console.WriteLine(isString);



            //object obj = "Hello";
            //object obj1 = 17;

            //TestClass test = new TestClass();
            //test.PublicNumber = 10;
        }
    }
}
