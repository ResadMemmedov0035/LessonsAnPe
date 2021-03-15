using System;

namespace Lesson_6
{
    class Program
    {
        class MyClass
        {
            public const int i = 100;

            public readonly int r;

            public MyClass(int a)
            {
                r = a;
            }

            /*
            private void Foo() // public olsa da xeta verecek (mentiqli olaraq)
            {
                r = 300; // error
            }
            */
        }

        class Person
        {
            public string name;
            public string surname;
            public int age;

            public Person() : this("N/A", "N/A", 0)
            {
                Console.WriteLine("parameterless ctor");
            }

            public Person(string name, string surname, int age)
            {
                Console.WriteLine("ctor with parameters");

                this.name = name;
                this.surname = surname;
                this.age = age;
            }
        }

        class MyClass2
        {
            static MyClass2()
            {
                Console.WriteLine("static ctor");
            }

            public MyClass2()
            {
                Console.WriteLine("parameterless ctor");
            }
        }

        static void Main(string[] args)
        {
            MyClass2 my21 = new MyClass2();
            MyClass2 my22 = new MyClass2();
            MyClass2 my23 = new MyClass2();
            MyClass2 my24 = new MyClass2();



            /*


            var person = new Person(surname: "Memmedov", name: "Resad", age: 17);

            var person1 = new Person()
            {
                name = "Resad",
                surname = "Memmedov",
                age = 17
            };

            var person2 = new Person();

            Console.WriteLine(person2.name);


            //var person2 = new Person();
            //person2.name = "Resad";
            //person2.surname = "Memmedov";
            //person2.age = 17;



            /*
            
            Console.WriteLine(Math.PI);

            // constantlar staticdir

            MyClass my = new MyClass(120);
            MyClass my1 = new MyClass(140);
            MyClass my2 = new MyClass(160);

            //my.r = 123;      // error
            //MyClass.i = 321; // error

            Console.WriteLine(MyClass.i);

            Console.WriteLine(my.r);
            Console.WriteLine(my1.r);
            Console.WriteLine(my2.r);




            /*
            int[] array = new int[] { 1, 2, 3, 4, 5 };

            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Array.Reverse(array);
            // ReverseArray(array);

            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            */
        }

        /*
        static void ReverseArray(int[] arr) // arr.Length
        {
            int[] temp = new int[arr.Length];

            arr.CopyTo(temp, 0);

            for (int i = 0; i < temp.Length; i++)
            {
                arr[i] = temp[temp.Length - i - 1];
            }
        }
        */

        // 1 2 3 4 5 6

        // 6 2 3 4 5 1
        // 6 5 3 4 2 1
        // 6 5 4 3 2 1

        /*
        static void ReverseArray(int[] arr) // arr.Length/2
        {
            for (int i = 0; i < arr.Length/2; i++)
            {
                // swap --> (a, b) = (b, a);
                (arr[i], arr[arr.Length - i - 1]) = (arr[arr.Length - i - 1], arr[i]);
            }
        }
        */

        /*
        static void ReverseArray(int[] arr) // arr.Length/2
        {
            int i = 0, len = arr.Length;

            while (i < len)
            {
                (arr[i], arr[len - 1]) = (arr[len - 1], arr[i]);
                i++;
                len--;
            }
        }
        */

        static void ReverseArray(int[] arr) // arr.Length/2
        {
            int len = arr.Length;

            for (int i = 0; i < len; i++, len--)
            {
                (arr[i], arr[len - 1]) = (arr[len - 1], arr[i]);
            }
        }

        static void ShowReverseArr(int[] arr)
        {
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
            }
        }

    }
}
