using System;
using System.Text;

namespace Lesson_3
{
    class MyClass
    {
        static public int a;

        public int b;
    }

    class Program
    {
        static string EvenOrOdd(int num) // even - cüt, odd - tek
        {
            if (num % 2 == 0) return "Cut";
            return "Tek";
        }

        static int FindMax(int a, int b)
        {
            return a > b ? a : b;
        }

        static void Main(string[] args)
        {

            /*             


            //MyClass.a = 10;

            //MyClass my = new MyClass();
            //my.b = 12;


            ///
            
            /// conditional operator (ternary operator)
            /// 
            /// ? :

            int num = 12;

            string str = num % 2 == 0 ? "Cut" : "Tek";

            string str1 = EvenOrOdd(num); // same as the above

            bool b = 10 > 5 ? true : false;

            /*

            /// Logical operators ///
            /// 
            /// &&, ||, !

            if (12 > 10 && 12 > 8) ; // true
            if (12 > 10 || 12 > 8) ; // true
            if (12 < 10 && 12 > 8) ; // false
            if (12 < 10 || 12 > 8) ; // true
            if (!(12 < 10)) ; // true
            if (!(12 > 10 || 12 < 8)) ; // false


            /*

            /// Relational operators ///
            /// 
            /// ==, !=, >, <, >=, <=,
            
            int number = Convert.ToInt32(Console.ReadLine());
            bool b = number % 2 == 0;

            if (b) Console.WriteLine("cut");
            else Console.WriteLine("tek");

            /*

            /// Assignment operators ///
            /// 
            /// =, +=, -=, /=, *=, %=


            /*

            /// Arithmetic operators ///
            /// 
            /// +, -, /, *, %,  ++ (increment), -- (decrement)

            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0) Console.WriteLine("Cut");
            else Console.WriteLine("Tek");

            int aa = 23 % 7; // aa = 2
            Console.WriteLine(aa);

            ///

            int num1 = 10 , num2 = 10;

            // postfix
            int a = num1++; // num1 = 11 , a = 10
            // prefix
            int b = ++num2; // num2 = 11 , b = 11

            Console.WriteLine(a + "  " + b);

            /*

            int a = 12 + 20; // +, *, -, %, sizeof, = kimileri operator
                             // 12, 20 kimileri ise operand

            // unary, binary, ternary

            // a++; // unary operator

            // 12+10 // binary operator

            // ? : // ternary operator

            */
        }
    }
}
