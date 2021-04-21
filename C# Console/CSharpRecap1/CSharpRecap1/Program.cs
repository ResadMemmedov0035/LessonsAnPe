using System;

namespace CSharpRecap1
{
    class MyClass
    {
        public void Foo()
        { 

        }
    }

    class Program
    {
        static int Factorial(int num)
        {
            if (num > 1)
                return num * Factorial(num - 1);
            return 1;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(5)); // 120


            //object o = new MyClass();
            //MyClass my = o as MyClass;

            //object obj = 10; // boxing | value --> reference
            //Console.WriteLine(obj);

            //int? i = obj as int?; // unboxing | reference --> value

            //object obj1 = "Hello"; // not boxing !
            //Console.WriteLine(obj1);
        }
    }
}
