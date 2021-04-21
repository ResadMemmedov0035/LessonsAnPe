using System;

namespace Lesson_12
{
    class MyClass
    {
        public void Foo()
        {
            Console.WriteLine("I am Foo");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            /*

            // int i = null; // error
            int? i1 = null;
            // Nullable<int> i1 = null // same as the above
            i1 ??= 10;
            Console.WriteLine(i1);


            // ?? null coalescing operator --> if(==null)
            // ?. null conditional operator --> if(!=null)


            /*

            MyClass my = null;
            my?.Foo(); // same as the below
            if(my != null) my.Foo();


            /*

            string str = null;

            str = str ?? "Hello";
            str ??= "Hello"; // same as the above

            string str1 = str ?? "Hello";

            //if (str == null)
            //{
            //    str1 = "Hello";
            //}
            //else str1 = str;

            //Console.WriteLine(str1);

            */
        }
    }
}
