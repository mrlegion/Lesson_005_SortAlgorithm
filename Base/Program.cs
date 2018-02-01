using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

using BubbleSort;
using InsertionSort;
using MargeSort;
using SelectionSort;

namespace Base
{
    class Program
    {
        private static Random random = new Random();
        static void Main(string[] args)
        {
            // --------------------- BUBBLE SORT -------------------------------------

            var bubble = Helper.GenerateRandomArray(15, 10, 90);
            Console.WriteLine("Массив до сортировки bubble:");
            Helper.Print(bubble);

            new Bubble().BubbleSort(ref bubble);

            Console.WriteLine("Массив после сортировки bubble:");
            Helper.Print(bubble);

            // Underline
            Console.WriteLine(new string('-', 50));
            
            // --------------------- INSETION SORT -------------------------------------

            var insertion = Helper.GenerateRandomArray(15, 10, 90);

            Console.WriteLine("Массив до сортировки insertion:");
            Helper.Print(insertion);

            Console.WriteLine("Массив после сортировки insertion:");
            new Insertion().InsertionSort(insertion);
            Helper.Print(insertion);
            
            // Underline
            Console.WriteLine(new string('-', 50));

            // --------------------- SELECTION SORT -------------------------------------

            var selection = Helper.GenerateRandomArray(15, 10, 90);
            Console.WriteLine("Массив до сортировки Selection:");
            Helper.Print(selection);

            Console.WriteLine("Массив после сортировки Selection:");
            new Selection().SelectionSort(selection);
            Helper.Print(selection);

            // Underline
            Console.WriteLine(new string('-', 50));

            // --------------------- MARGE SORT -------------------------------------

            var marge = Helper.GenerateRandomArray(100, 1, 1000);
            Console.WriteLine("Массив до сортировки Marge:");
            Helper.Print(marge);

            Console.WriteLine("Массив после сортировки Marge:");
            new Marge().Sort(marge);
            Helper.Print(marge);

            // Underline
            Console.WriteLine(new string('-', 50));

            // --------------------- MARGE SORT -------------------------------------


            // Delay
            Console.ReadKey();
        }
    }
}
