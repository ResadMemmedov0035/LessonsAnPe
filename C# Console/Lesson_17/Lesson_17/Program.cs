using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;

namespace Lesson_17
{
    class MyClass : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Done");
        }
    }
  
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString() =>
            $"{Name}, {Age}";
    }

    class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person>
            {
                new Person { Name = "Resad", Age = 17 },
                new Person { Name = "Perviz", Age = 21 },
                new Person { Name = "Rasim", Age = 20 },
            };

            var data = JsonSerializer.Serialize(people);
            File.WriteAllText("people.json", data);



            //var data = File.ReadAllText("person.json");
            //var person = JsonSerializer.Deserialize<Person>(data);

            //Console.WriteLine(person);


            //var person = new Person { Name = "Rasim", Age = 20 };

            //var data = JsonSerializer.Serialize(person);
            //File.WriteAllText("person.json", data);




            /* XML Serilazition
             *      requires:
             *      - public class
             *      - parameterless ctor
             * *

            var xmlSerializer = new XmlSerializer(typeof(Person));

            using (var fstream = new FileStream("person.xml", FileMode.Open))
            {
                var person = xmlSerializer.Deserialize(fstream) as Person;
                Console.WriteLine(person);
            };

            //var person = new Person("Perviz", 21);

            //using (var fstream = new FileStream("person.xml", FileMode.Create)) 
            //{
            //    xmlSerializer.Serialize(fstream, person);
            //}



            /* Binary Serilazition
             *      requires:
             *      - [Serializable]
             * *

            var formatter = new BinaryFormatter();

            var people = new List<Person>
            {
                new Person{ Name = "Resad", Age = 17},
                new Person{ Name = "Rasim", Age = 20},
                new Person{ Name = "Perviz", Age = 21},
            };

            using (var fstream = new FileStream("people.bin", FileMode.Create))
            {
                formatter.Serialize(fstream, people);
            }


            /*

            var person = new Person { Age = 21, Name = "Perviz" };

            using (var fstream = new FileStream("person.bin", FileMode.Open))
            {
                var person1 = formatter.Deserialize(fstream) as Person;
                Console.WriteLine(person1);
            }

            //using (var fstream = new FileStream("person.bin", FileMode.Create))
            //{
            //    formatter.Serialize(fstream, person);
            //}




            /*
             

            using (var fstream = new FileStream("somelines.txt", FileMode.Open))
            {
                using (var sreader = new StreamReader(fstream))
                {
                    while (!sreader.EndOfStream)
                    {
                        var str = sreader.ReadLine();
                        Console.WriteLine(str);
                    }
                }
            }

            using (var fstream = new FileStream("somelines.txt", FileMode.Create))
            {
                using (var swriter = new StreamWriter(fstream))
                {
                    var strs = new string[] { "Hi", "My", "Name", "Is", "Resad" };

                    foreach (var item in strs)
                    {
                        swriter.WriteLine(item);
                    }
                }
            }


            using (var fstream = new FileStream("sometext.txt", FileMode.Open))
            {
                using (var sreader = new StreamReader(fstream))
                {
                    var str = sreader.ReadToEnd();
                    Console.WriteLine(str);
                }
            }

            using (var fstream = new FileStream("sometext.txt", FileMode.Create))
            {
                using (var swriter = new StreamWriter(fstream))
                {
                    swriter.Write("Hello");
                }
            }




            //using (var fstream = new FileStream("sometext.txt", FileMode.Open))
            //{
            //    byte[] bts = new byte[50];
            //    fstream.Read(bts, 0, bts.Length);
            //    var str = Encoding.UTF8.GetString(bts);
            //    Console.WriteLine(str);
            //}


            /*

            //using (var my = new MyClass())
            //{
            //    Console.WriteLine("Ok");
            //}

            /*

            //using (var fstream = new FileStream("sometext.txt", FileMode.Create))
            //{
            //    var str = "New Info";
            //    var bts = Encoding.UTF8.GetBytes(str);
            //    fstream.Write(bts, 0, bts.Length);
            //}

            //FileStream fstream = new FileStream("sometext.txt", FileMode.Append);

            //var str = "New Info";
            //var bts = Encoding.UTF8.GetBytes(str);
            //fstream.Write(bts, 0, bts.Length);
            //fstream.Close();



            /*

            var strs = File.ReadAllLines("testlines.txt");
            foreach (var s in strs)
            {
                Console.WriteLine(s);
            }

            var str = File.ReadAllText("test.txt");
            Console.WriteLine(str);

            /*
             
            var strs = new string[] { "Hi", "My", "Name", "Is", "Resad" };

            File.WriteAllLines("testlines.txt", strs);


            File.WriteAllText(@"../../../mytext.txt", "Hello Perviz");

            File.WriteAllText(@"C:\Users\hp\Desktop\test.txt", "Hello World");

            File.WriteAllText("test.txt", "Hello World");

            */
        }
    }
}
