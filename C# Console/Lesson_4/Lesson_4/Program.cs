using System;

namespace Lesson_4
{
    class MyClass // default access modifier is internal
    {
        private int privateNum;

        public int publicNum;

        public MyClass(int num) // class yaradilan zaman ise dusur
        {
            this.privateNum = num;
        }

        public void PrintNum()
        {
            Console.WriteLine(privateNum);
        }
    }

    struct MyStruct
    {
        public int a;
        public int b;

        public MyStruct(int a, int b) // butun field-lerin menimsedilmesini teleb edir
        {
            this.a = a;
            this.b = b;
        }
    }

    struct Point
    {
        public int x;
        public int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    class Program
    {
        static int FindMax(int a, int b, int c, int d)
        {
            return a > b && a > c && a > d ? a : 
                            b > c && b > d ? b : 
                                     c > d ? c : d;
        }

        static int Factorial(int num)
        {
            int a = 1;
            for (int i = 1; i < num;)
            {
                i++;
                a *= i;
            }
            return a;
        }

        static int RecursionFactorial(int num)
        {
            if (num > 1) return num * RecursionFactorial(num - 1);
            return 1;
        }

        static void Main(string[] args)
        {
            int a = 12;
            int b = 10;

            switch (a)
            {
                case b: // case -ler constant olmalidir
                    Console.WriteLine("I am 10");
                    break;
                case 11:
                    Console.WriteLine("I am 11");
                    break;
                case 12:
                    Console.WriteLine("I am 12");
                    break;
                default:
                    break;
            }

            /*

            do
            {
                // numune aglima gelmedi X(
            } while ();


            /*

            int a = 0;
            while (a < 10)
            {
                a++;
                Console.WriteLine(a);
            }


            /*

            int i = 1;
            for (; i <= 10; i++)
            {
                Console.WriteLine(i);
            }



            /*

            int a = 150;

            if (a > 100)
            {
                Console.WriteLine("a 100-den boyukdur");
            }
            else if (a > 70)
            {
                Console.WriteLine("a 70-den boyukdur 100-den kicikdir");

            }
            else if (a > 50)
            {
                Console.WriteLine("a 50-den boyukdur 70-den kicikdir");

            }
            else
            {
                Console.WriteLine("a ferqli bir ededir");
            }


            /*

            MyStruct myStruct = new MyStruct(12, 32);

            //myStruct.a = 10;
            //myStruct.b = 11;

            Console.WriteLine(myStruct.a);
            Console.WriteLine(myStruct.b);

            /*

            MyClass my = new MyClass(34);

            my.publicNum = 21;
            Console.WriteLine(my.publicNum);

            my.PrintNum();



            /*

            Console.WriteLine(RecursionFactorial(1));
            Console.WriteLine(RecursionFactorial(2));
            Console.WriteLine(RecursionFactorial(5));

            */

            /*

            long number = 4_123_243_500_321; // digit seperator
            Console.WriteLine(number);

            /*

            int max = FindMax(1, 2, 3, 4);
            Console.WriteLine(max);

            */
        }
    }
}
