using System;

namespace Lesson_11
{
    class MyException : Exception
    {
        public override string Message => "MyException Message";
    }

    class Program
    {
        static void Foo(int naturalNumber)
        {
            if (naturalNumber < 1) 
                throw new Exception("Number is not natural.");

            Console.WriteLine(naturalNumber);
        }



        static void Main(string[] args)
        {

            uint a = uint.MaxValue;

            unchecked
            {
                a++;
            }
            //checked
            //{
            //    a++;
            //}
            Console.WriteLine(a);







            //try
            //{
            //    throw new MyException();

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex);
            //}


            //int num = -10;
            //if(num >= 1)
            //    Foo(num);


            //int a = 10, b = 0;
            //try
            //{
            //    Console.WriteLine(a / b);
            //    // throw new Exception("Exception has throwed");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex);
            //}
        }
    }
}
