using System;

namespace Lesson_7
{
    class Person
    {
        private int age;

        public string Name { get; set; }
        public string Surname { get; set; } // snippet --> prop
        public int Age // snippet --> propfull
        {
            get => age;
            set 
            {
                if (value > 0)
                    age = value;
            }
        }

        public int MyProperty { get; } = 100; // readonly property

        public int MyProp { get; private set; } = 1200;

        public Person()
        {
            MyProperty = 120;
        }

        public void Foo()
        {
            // MyProperty = 1200; // error
            MyProp = 1200; // not error
        }
    }

    class MyArray
    {
        private int[] array;

        public int this[int index]
        {
            get => array[index];
            set => array[index] = value;
        }

        public int Length { get; }

        public MyArray(int len)
        {
            array = new int[len];
            Length = len;
        }
    }

    enum MyEnum
    {
        Apple = 5, Banana = 8, Cherry, Delight
    }

    enum DaysOfWeek : byte
    {
        Monday = 1, Tuesday, Wednesday, Thrusday, Friday, Saturday, Sunday
    }

    partial class SomeClass
    {
        public void Method1()
        {
            Console.WriteLine("I am method one");
        }
    }

    partial class SomeClass
    {
        public void Method2()
        {
            Console.WriteLine("I am method two");
        }
    }

    partial class AnotherClass
    {
        partial void Method();
    }

    partial class AnotherClass
    {
        partial void Method()
        {
            Console.WriteLine("I am partial method");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            random.Next();          // int-in ala bileceyi musbet qiymetler (0 daxil)
            random.Next(100);       // 0-dan 100-e kimi (100 daxil deyil)
            random.Next(-100, 100); // -100-den 100-e kimi (100 daxil deyil)

            Console.WriteLine(random.NextDouble());

            /*

            var someClass = new SomeClass();
            someClass.Method1();
            someClass.Method2();


            /*

            string[] names = Enum.GetNames(typeof(DaysOfWeek));

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();


            Console.Write("Heftenin gunu daxil edin: ");
            int num = int.Parse(Console.ReadLine());
            DaysOfWeek day = (DaysOfWeek)num;

            if (day == DaysOfWeek.Monday) Console.WriteLine("Lenet olsun");
            else if (day == DaysOfWeek.Friday) Console.WriteLine("YEAH");

            Console.WriteLine(day.GetTypeCode());


            Console.WriteLine((int)MyEnum.Apple);
            Console.WriteLine((int)MyEnum.Banana);
            Console.WriteLine((int)MyEnum.Cherry);


            /*

            var myArray = new MyArray(5);

            myArray[2] = 10;

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i] + " ");
            }


            /*

            Person person = new Person();
            person.Name = "Resad";
            person.Age = -17;
            Console.WriteLine(person.Name + "  " + person.Age);

            // person.MyProperty = 122; // error
            // person.MyProp = 320;    // error

            */
        }
    }
}
