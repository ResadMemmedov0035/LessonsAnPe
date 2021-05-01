using System;
using System.Collections;
using System.Collections.Generic;

namespace Lesson_16
{
    class MyArray<T> : IEnumerable
    {
        private T[] array;

        public T this[int index]
        {
            get => array[index];
            set => array[index] = value;
        }

        public MyArray(params T[] arr)
        {
            array = arr;
        }

        public IEnumerator GetEnumerator()
        {
            foreach (var item in array)
            {
                yield return item;
            }
        }

        //class Enumerator : IEnumerator
        //{
        //    private T[] arr;
        //    private int index = -1;

        //    public Enumerator(T[] arr) => this.arr = arr;

        //    public object Current => arr[index];

        //    public bool MoveNext() => ++index < arr.Length;

        //    public void Reset() => index = -1;
        //}
    }

    class Program
    {
        static IEnumerator<string> Foo()
        {
            yield return "First";
            yield return "Second";
            yield return "Third";
        }

        static void Method<T>(T param) where T : new() // IEnumerable, ICloneable // class // struct
        {
            
        }

        class MyClass
        {
            public MyClass()
            {

            }
            public MyClass(int i)
            {

            }
        }

        static void Main(string[] args)
        {


            Method(new MyClass());


            //Foo().MoveNext();
            //    Console.WriteLine(Foo().Current);
            


            //var arr = new MyArray<int>(1, 2, 3, 4, 5);

            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();


            //var iterator = arr.GetEnumerator();

            //while (iterator.MoveNext())
            //{
            //    Console.WriteLine(iterator.Current);
            //}
            //iterator.Reset();

            //while (iterator.MoveNext())
            //{
            //    Console.WriteLine(iterator.Current);
            //}
        }
    }
}
