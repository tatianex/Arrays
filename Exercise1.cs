using System;

namespace arrays {
    class ExerciseOne {
        public static void One(string[] args)
        {
            Console.Write("Exercício 1.\nLeia dois arrays A e B com 15 elementos.\n");
            Console.WriteLine("Construir um array C, onde cada elemento de C é a subtração do elemento correspondente de A com B.\n");

            int[] a = new int[15] {44, 28, 59, 68, 63, 55, 42, 89, 75, 84, 104, 79, 78, 81, 96};
            int[] b = new int[15] {17, 19, 5, 10, 45, 50, 23, 35, 34, 14, 12, 25, 28, 39, 40};
            int[] c = new int[15];

            for (int i = 0; i < 15; i++) {
                c[i] = a[i] - b[i];
                Console.Write($"{c[i]}, ");
            }
            Console.ReadLine();
        }
    }
}