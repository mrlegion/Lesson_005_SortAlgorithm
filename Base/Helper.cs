using System;

namespace Base
{
    public class Helper
    {
        private static Random random = new Random();

        public static int[] GenerateRandomArray(int size, int start, int end)
        {
            if (size < 0)
                throw new ArgumentException();

            var result = new int[size];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = random.Next(start, end);
            }

            return result;
        }

        public static int[] GenerateRandomArray(int size)
        {
            return GenerateRandomArray(size, 10, 99);
        }


        public static void Print(int[] array)
        {
            foreach (int i in array)
            {
                Console.Write($" {i} ");
            }

            Console.WriteLine();
        }

        public static void PrintHr()
        {
            Console.WriteLine(new string('-', 70));
        }

        public static void PrintTitle(string name, int[] array)
        {
            Console.WriteLine($"Массив до сортировки {name}:");
            Print(array);
            Console.WriteLine();
        }

        public static void PrintBodySort(string name, int[] array)
        {
            Console.WriteLine($"vМассив после сортировки {name}:");
            Print(array);
            Console.WriteLine();
            PrintHr();
        }

        public static void ExamplePrint(Example type, int size)
        {
            var temp = GenerateRandomArray(size, 1, 100);
            Console.WriteLine($"Массив до сортировки {type.ToString()}:");
            Print(temp);
            Console.WriteLine();

            switch (type)
            {
                case Example.Bubble:
                    new BubbleSort.Bubble().BubbleSort(ref temp);
                    break;
                case Example.Selection:
                    new SelectionSort.Selection().SelectionSort(temp);
                    break;
                case Example.Insertion:
                    new InsertionSort.Insertion().InsertionSort(temp);
                    break;
                case Example.Marge:
                    new MargeSort.Marge().Sort(temp);
                    break;
                case Example.Fast:
                    break;
            }

            Console.WriteLine($"Массив после сортировки {type.ToString()}:");
            Print(temp);
            Console.WriteLine();
            PrintHr();
        }
    }
}
