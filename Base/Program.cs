using System;

namespace Base
{
    class Program
    {
        static void Main(string[] args)
        {
            // --------------------- BUBBLE SORT -------------------------------------

            Helper.ExamplePrint(Example.Bubble, 10);

            // --------------------- INSETION SORT -------------------------------------

            Helper.ExamplePrint(Example.Insertion, 10);


            // --------------------- SELECTION SORT -------------------------------------

            Helper.ExamplePrint(Example.Selection, 10);


            // --------------------- MARGE SORT -------------------------------------

            Helper.ExamplePrint(Example.Marge, 10);


            // --------------------- FAST SORT -------------------------------------

            Helper.ExamplePrint(Example.Fast, 10);

            // Delay
            Console.ReadKey();
        }
    }
}
