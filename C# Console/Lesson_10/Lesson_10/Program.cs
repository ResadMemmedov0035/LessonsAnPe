using System;
using System.Collections.Generic;
using System.Threading;

namespace Lesson_10
{
    class Person
    {
        public string Name { get; set; }
        public string Password { get; set; }

        public override string ToString()
        {
            return $"{Name}, {Password}";
        }
    }

    enum MyEnum : byte
    {
        Apple, Banana, Cherry
    }

    static class MyExtensions
    {
        public static void Print<T>(this List<T> list, int num)
        {
            foreach (var item in list)
                Console.WriteLine(item);
        }
    }

    class Program
    {
        static void Swap(ref int item1, ref int item2)
        {
            int temp = item1;
            item1 = item2;
            item2 = temp;
        }

        static void Swap(ref Person p1, ref Person p2)
        {
            Person temp = p1;
            p1 = p2;
            p2 = temp;
        }


        static void Method1(ref int a) // may be changed
        {
            // a = 12;
            Console.WriteLine(a);
        }
        static void Method2(out int a) // must be changed
        {
            a = 12;
        }
        static void Method3(in int a) // cannot changed
        {
            Console.WriteLine(a);
        }


        static void Main(string[] args)
        {

            var begin = DateTime.Now;

            int i = 0;
            while (i < 10_000)
            {
                i++;
            }

            var end = DateTime.Now;

            var substract = end - begin;
            Console.WriteLine(substract.TotalMilliseconds);



            //while (true)
            //{
            //    Console.WriteLine(DateTime.Now.ToLongTimeString());
            //    Thread.Sleep(900);
            //    Console.Clear();
            //}



            /*

            List<int> list = new List<int> { 1, 2, 3, 4, 5 };
            list.Print(12);


            /*

            if (int.TryParse("134wer", out int a))
            {
                Console.WriteLine(a);
            }


            /*

            Person person1 = new Person { Name = "Resad", Password = "1234"};
            Person person2 = new Person { Name = "Behruz", Password = "5678" };

            Console.WriteLine("person 1 : " + person1);
            Console.WriteLine("person 2 : " + person2);

            Swap(ref person1, ref person2);

            Console.WriteLine("person 1 : " + person1);
            Console.WriteLine("person 2 : " + person2);

            //int a = 12, b = 34;
            //Swap(ref a, ref b);

            //Console.WriteLine("a: " + a);
            //Console.WriteLine("b: " + b);


            /*

            int a = 10;

            string str = a switch
            { 
                1 => "Hello",
                2 => "Hi",
                3 => "Nope",
                _ => "I am default"
            };

            switch (a)
            {
                case 1:
                    str = "Hello";
                    break;
                case 2:
                    str = "Hi";
                    break;
                case 3:
                    str = "Nope";
                    break;
                default:
                    break;
            }


            /*

            MyEnum myEnum = MyEnum.Apple;

            switch (myEnum)
            {
                case MyEnum.Apple:
                    Console.WriteLine("It is Apple");
                    break;
                case MyEnum.Banana:
                    Console.WriteLine("It is Banana");
                    break;
                case MyEnum.Cherry:
                    Console.WriteLine("It is Cherry");
                    break;
                default:
                    break;
            }

            */
        }
    }
}
