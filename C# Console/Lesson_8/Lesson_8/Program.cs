using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_8
{
    class MyArray<T>
    {
        private T[] arr;

        public int Length { get; }

        public T this[int index]
        {
            get => arr[index];
            set => arr[index] = value;
        }

        public MyArray(int len)
        {
            arr = new T[len];
            Length = len;
        }
    }

    class MyList<T>
    {
        private T[] arr;

        public int Count => arr.Length;

        public T this[int index]
        {
            get => arr[index];
            set => arr[index] = value;
        }

        public MyList(params T[] array)
        {
            arr = array;
        }

        public void Add(T item)
        {
            T[] tempArr = new T[arr.Length + 1];

            arr.CopyTo(tempArr, 0);

            tempArr[tempArr.Length - 1] = item;

            arr = tempArr;
        }
    }

    class Program
    {
        static string GenerateRandomPassword(int len)
        {
            Random rand = new Random();

            string password = string.Empty;

            string str = "qwertyuiopasdfghjklzxcvbnm" +
                        "QWERTYUIOPASDFGHJKLZXCVBNM" +
                        "1234567890";

            for (int i = 0; i < len; i++)
            {
                password += str[rand.Next(0, str.Length)];
            }

            return password;
        }

        static void Randomizer<T>(T[] arr)
        {
            Random rand = new Random();

            int len = arr.Length;

            while (len > 1)
            {
                int r = rand.Next(0, len);
                (arr[r], arr[len - 1]) = (arr[len - 1], arr[r]);
                len--;
            }
        }

        static void Print<T>(T item)
        {
            Console.WriteLine(item);
        }

        static void Main(string[] args)
        {
            var list = new List<int>
            {
                1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17
            };

            list.TrimExcess();

            Console.WriteLine(list.Count);
            Console.WriteLine(list.Capacity);


            list.Contains(3); // true
            list.Contains(100); // false

            list.Sort(); // sorting (sadece int-lerde)

            list.Reverse(); // reverse edir

            list.ToArray(); // array-e donusturur

            list.Clear(); // adinnan melum

            /*

            MyList<int> list = new MyList<int>(1, 2, 3, 4, 5);

            for (int i = 0; i < list.Count; i++)
                Console.Write(list[i] + " ");
            Console.WriteLine();

            list.Add(6);

            for (int i = 0; i < list.Count; i++)
                Console.Write(list[i] + " ");


            /*

            var list = new List<string>
            {
                "Hello",
                "World",
                "Hi",
                "Excuse",
                "Me"
            };

            //list.Add("Hello");
            //list.Add("World");
            //list.Add("Hi");
            //list.Add("Excuse");
            //list.Add("Me");

            list.Remove("World");
            list.Remove("Me");

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }


            /*

            var intArr = new MyArray<string>(5);
            intArr[0] = "Hello";
            intArr[1] = "World";
            intArr[2] = "Hi";
            intArr[3] = "Excuse";
            intArr[4] = "Me";

            for (int i = 0; i < intArr.Length; i++)
            {
                Console.WriteLine(intArr[i]);
            }


            /*

            string[] strArr = new string[] { "Hello", "World", "Hi", "Excuse", "For", "Me" };

            foreach (var item in strArr)
                Console.Write(item + " ");
            Console.WriteLine();

            Randomizer(strArr);

            foreach (var item in strArr)
                Console.Write(item + " ");
            Console.WriteLine("\n");


            Print(15);
            Print("Hello");
            Print(true);
            Print(1.45f);


            /*

            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.UTF8;
            //Console.OutputEncoding = Encoding.UTF7;
            //Console.OutputEncoding = Encoding.Unicode;

            Console.Write("Adinizi daxil edin: ");
            string name = Console.ReadLine();
            Console.WriteLine(name);

            Console.WriteLine("Pərviz");


            /*

            int[] arr = new int[] { 1, 2, 3, 4, 5 };

            foreach (var item in arr)
                Console.Write(item + " ");
            Console.WriteLine();

            Randomizer(arr);

            foreach (var item in arr)
                Console.Write(item + " ");


            /*

            string password;

            for (int i = 0; i < 10; i++)
            {
                password = GenerateRandomPassword(8);
                Console.WriteLine(password);
            }

            */
        }
    }
}
