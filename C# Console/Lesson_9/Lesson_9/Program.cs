using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_9
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }



    class Program
    {
        static string GenerateRandomPassword(int len)
        {
            Random rand = new Random();
            StringBuilder password = new StringBuilder(len);

            string str = "qwertyuiopasdfghjklzxcvbnm" +
                        "QWERTYUIOPASDFGHJKLZXCVBNM" +
                        "1234567890";

            for (int i = 0; i < len; i++)
            {
                password.Append(str[rand.Next(0, str.Length)]);
            }

            return password.ToString();
        }

        static void Main(string[] args)
        {

            /*


            //string str = "Hello";
            //char[] chArr = str.ToCharArray();


            //string str = "Hello";
            //Console.WriteLine(str.Substring(3)); // lo
            //Console.WriteLine(str.Substring(0, 2)); // He



            //string str = "Resad Memmedov,17";
            //string[] strArr = str.Split(' ', ',');

            //Console.WriteLine($"{strArr[0]} {strArr[1]} {strArr[2]}");


            //string str = "Hello";
            //Console.WriteLine(str.Replace('o', 'z')); // Hellz
            //Console.WriteLine(str.Replace('l', 'a')); // Heaao


            //string str = "Hello";
            //Console.WriteLine(str.Remove(3)); // Hel
            //Console.WriteLine(str.Remove(0, 2)); // llo


            //string str = "Hello";
            //Console.WriteLine(str.PadLeft(10));
            //Console.WriteLine(str.PadRight(10) + "World");


            //string str = "Hello";
            //Console.WriteLine(str.IndexOf('e'));    // 1
            //Console.WriteLine(str.IndexOf('l'));   // 2
            //Console.WriteLine(str.IndexOf('l', 3)); // 3
            //Console.WriteLine(str.IndexOf('z'));   // -1


            //string str = "Hello";
            //Console.WriteLine(str.EndsWith("o")); // true
            //Console.WriteLine(str.EndsWith("lo")); // true
            //Console.WriteLine(str.EndsWith("klo")); // false

            //str.StartsWith('H'); // true
            //str.StartsWith('h'); // false


            //string str = "HeLLo";
            //Console.WriteLine(str.ToLower());

            //string str = "Hello";
            //Console.WriteLine(str.ToUpper());


            //string str = "Hello";
            //Console.WriteLine(str.Contains("He")); // true
            //Console.WriteLine(str.Contains("Het")); // false


            //string str = "  \tHello  a";
            //Console.WriteLine(str.Trim());



            /*

            var dic = new Dictionary<string, int>();


            dic.Add("Hello", 1);
            dic.Add("World", 2);
            dic.Add("Hi", 3);
            dic.Add("Excuse", 8);

            if (dic.TryAdd("Hello1", 12))
            {
                Console.WriteLine("Elave olundu");
            }
            else Console.WriteLine("Elave oluna bilmedi");

            // dic.Add("Hello", 10); // error



            dic.Remove("Hello");

            Console.WriteLine(dic.ContainsKey("World")); // true
            Console.WriteLine(dic.ContainsKey("Worldewrw")); // false


            foreach (var item in dic.Keys)
                Console.WriteLine(item);

            foreach (var item in dic.Values)
                Console.WriteLine(item);

            Console.WriteLine(dic["Hello"]);

            //foreach (var item in dic)
            //    Console.WriteLine(item);



            /*

            var list = new List<int>() { 1, 2, 3, 4 };

            list.Insert(0, 8); // 8 1 2 3 4
            list.Insert(1, 8); // 1 8 2 3 4
            list.Insert(2, 8); // 1 2 8 3 4


            /*

            var people = new List<Person>
            {
                new Person { Name = "Resad", Age = 17 },
                new Person { Name = "Perviz", Age = 20 }
            };

            var person = people[0];
            Console.WriteLine(people.Contains(person)); // true

            //var person = new Person { Name = "Resad", Age = 17 };
            //Console.WriteLine(people.Contains(person)); // false


            var list = new List<int>() { 1, 2, 3, 4 };
            var list1 = new List<int>() { 5, 6, 7 };
            var arr = new int[] { 9, 10 };

            list.Contains(4); // true
            list.Contains(100); // false


            /*

            foreach (var item in list)
                Console.Write(item + " ");
            Console.WriteLine();

            list.AddRange(arr); // same as lis1

            foreach (var item in list)
                Console.Write(item + " ");


            */
        }
    }
}
