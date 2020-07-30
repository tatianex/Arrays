using System;
using System.Linq;

namespace arrays {
    class ExerciseFour {
        public static void Four(string[] args)
        {
            Console.WriteLine("Exercício 4.\nLeia dois arrays A e B com 10 elementos.");
            Console.WriteLine("Em seguida, compare os arrays e verifique se os mesmos são iguais ou diferentes.\n");

            int[] a = new int[10] {13, 22, 8, 40, 31, 25, 49, 20, 68, 82};
            int[] b = new int[10] {13, 22, 8, 40, 31, 25, 49, 20, 68, 82};
            //int[] b = new int[10] {57, 3, 6, 32, 16, 19, 43, 27, 54, 73};

            foreach (int element in a) Console.Write($"{element}, ");
            Console.WriteLine("\n");
            foreach (int element in b) Console.Write($"{element}, ");
            Console.WriteLine("\n");

            bool isEqual = Enumerable.SequenceEqual(a, b);

            if (isEqual == true) Console.WriteLine("São iguais.");
            else Console.WriteLine("São diferentes.");

            Console.ReadLine();
        }
    }
}