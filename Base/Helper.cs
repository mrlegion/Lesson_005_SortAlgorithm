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
    }
}
