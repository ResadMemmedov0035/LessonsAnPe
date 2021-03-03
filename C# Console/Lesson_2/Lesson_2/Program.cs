using System;
using System.Text;

namespace Lesson_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*

            string s = "1234a";
            if (int.TryParse(s, out int result))
            {
                int a = result; // Convert.ToInt32(s), int.Parse(s);
                Console.WriteLine(a);
            }

            /*
             
            for (int i = 0; i < 256; i++)
            {
                Console.WriteLine(i + "  " + (char)i);
            }

            long l = 100;
            int i = (int)l; // explicit(aşkar) casting

            int i1 = 100;
            long l1 = i1; // implicit(qeyri-aşkar) casting


            /*

            byte // 0 - 255
            sbyte // -128 - 127


            // int - 4 byte
            
            int.MaxValue // 2.1 mlyrd+
            int.MinValue // -(int.MaxValue + 1)

            // uint - 4 byte

            uint.MaxValue // 4.2 myrld+
            uint.MinValue // 0

            // ushort, ulong -- eyni mentiq


            /*

            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Console.Write("Adinizi daxil edin: ");
            Console.WriteLine($"Salam {Console.ReadLine()}");

            Console.WriteLine("Əkbər");



            /*

            // 20 default olaraq int
            // 10.43 default olaraq double

            float f = 1000 / 3F;
            double d = 1 / 3D;
            decimal m = 1 / 3M;

            Console.WriteLine(f);
            Console.WriteLine(d);
            Console.WriteLine(m);

            Console.WriteLine("{0:N}", m);
            Console.WriteLine("{0:N2}", m); // same as the above
            Console.WriteLine("{0:C}", 15); // currency format

            Console.WriteLine($"{m} --- {d}");

            /*

            var flt = 10.5F; // float 
            var doubl = 12.43D; // double
            var dec = 21.33M; // decimal

            /*

            byte; // 1 byte

            int; // 4 byte
            short; // 2 byte
            long; // 8 byte
            
            // c++ char // 1 byte // ascii
            char; // 2 byte // unicode
            string; // char array

            float; // 4 byte
            double; // 8 byte
            decimal; // 16 byte

            */
        }
    }
}
