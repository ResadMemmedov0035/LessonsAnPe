using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_14
{
    interface IInterface<T>
    {
        int GetT(T param);
    }

    interface IFlyable
    {
        void Fly();
    }

    abstract class Animal
    {
        public int Age { get; set; }

        public abstract void Sound();
    }

    class Bird : Animal, IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("I am a bird and I can fly!");
        }

        public override void Sound()
        {
            Console.WriteLine("Cik Cik");
        }
    }

    class Plane : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("I am a plane and I can fly!");
        }
    }

    class Test : ICloneable, IComparable<Test>
    {
        public int Number { get; set; }

        public object Clone()
        {
            return new Test
            {
                Number = this.Number
            };
        }

        public int CompareTo(Test other)
        {
            return Number.CompareTo(other.Number);
            // return Number - other.Number;
        }
    }

    class MyClass
    {
        public static int PublicProp { get; set; }
        protected static int ProtectedProp { get; set; }

        internal static int InternalProp { get; set; }
    }

    /*internal*/ class DerivedClass : MyClass
    {
        /*private*/ int num;

        public DerivedClass()
        {
            ProtectedProp = 10;
        }
    }

    class SomeClass
    {
        protected internal int MyProperty { get; set; }
        private protected int MyProperty1 { get; set; }
    }

    interface ITest
    {

    }

    class TestClass : ITest
    {
        public int SomeData { get; set; }
    }

    class Program
    {
        static void TestMethod<T>(T data)
        {
            Console.WriteLine(data as ITest);
        }

        static void Main(string[] args)
        {
            TestClass test = new TestClass { SomeData = 12 };

            Console.WriteLine(test);

            TestMethod(test);


            // public, protected, private, internal


            SomeClass some = new SomeClass();


            //ClassLibrary1.Class1 class1 = new ClassLibrary1.Class1();
            //class1.



            //MyClass.PublicProp = 10;
            //MyClass.InternalProp = 10;

            /*

            Test test = new Test { Number = 10 };
            Test test1 = new Test { Number = 12 };

            Console.WriteLine(test.CompareTo(test1));


            /*

            Test test2 = new Test { Number = 5 };

            Test test3 = (Test)test2.Clone(); // deep copy
            test3.Number = 300;

            Console.WriteLine(test2.Number);


            Test test = new Test();
            test.Number = 10;

            Test test1 = test; // shallow copy
            test1.Number = 20;

            Console.WriteLine(test.Number);

            /*

            IFlyable bird = new Bird();
            bird.Fly();

            IFlyable plane = new Plane();
            plane.Fly();

            */
        }
    }
}
