using System;

namespace Lesson_5
{
    class MyClass
    {
        public int a;
    }

    class Program
    {
        static void Foo(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + ' ');
            }
        }

        static void FooParam(params int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + ' ');
            }
        }

        static void Main(string[] args)
        {
            /*
             
            Foo(new int[] { 10, 20, 30, 40, 50 });

            FooParam(10, 20, 30, 40, 50);



            /*

            int[][] array = new int[2][] // jagged array
            {
                new int[] { 1, 2, 3, 4, 5 },
                new int[] { 6, 7, 8 }
            };

            foreach (var arr in array)
            {
                foreach (var item in arr)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }


            /*

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine
                        ($"{i} * {j} = {i * j}");
                }
                Console.WriteLine("-----------------------");
            }


            /*
             
            int[,,] array = new int[10, 10, 2];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j, 0] = i + 1;
                    array[i, j, 1] = j + 1;
                }
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.WriteLine
                        ($"{array[i, j, 0]} * {array[i, j, 1]} = {array[i, j, 0] * array[i, j, 1]}");
                }
                Console.WriteLine("-----------------------");
            }


            /*
            
            int[,,] _3DArray = new int[2, 2, 3]
            {
                {
                    { 1, 2, 3 },
                    { 4, 5, 6 }
                },
                {
                    { 7, 8, 9 },
                    { 10, 11, 12 }
                }
            };

            for (int i = 0; i < _3DArray.GetLength(0); i++)
            {
                for (int j = 0; j < _3DArray.GetLength(1); j++)
                {
                    for (int k = 0; k < _3DArray.GetLength(2); k++)
                    {
                        Console.Write(_3DArray[i, j, k] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("------------------------------");
            }


            /*

            int[,] _2DArray = new int[2, 3]
            {
                {1,2,3 },
                {4,5,6 }
            };

            for (int i = 0; i < _2DArray.GetLength(0); i++)
            {
                for (int j = 0; j < _2DArray.GetLength(1); j++)
                {
                    Console.Write(_2DArray[i, j]);
                }
                Console.WriteLine();
            }


            foreach (var item in _2DArray)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.WriteLine(_2DArray[0, 1]); // 2
            Console.WriteLine(_2DArray[1, 2]); // 6

            /*

            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }


            /*

            int[] arr = new int[] { 10, 20, 30, 40, 50 }; // new int[5] { 1, 2, 3, 4, 5 }; //new int[5]; 
            int[] arr1 = new int[arr.Length];

            arr.CopyTo(arr1, 0); // same as the below

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr1[i] = arr[i];
            //}

            arr1[0] = 2132;
            Console.WriteLine(arr1[0]); // 2132
            Console.WriteLine(arr[0]); // 10

            /*

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }



            /*

            int[] copyArr = arr;

            Console.WriteLine(copyArr[0]);

            copyArr[0] = 10;

            Console.WriteLine(copyArr[0]);

            */
        }
    }
}
