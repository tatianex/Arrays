using System;

namespace arrays {
    class ExerciseSix {
        public static void Six(string[] args)
        {
            Console.WriteLine(String.Join(
                Environment.NewLine,
                "Exercício 6.",
                "Leia um array A com 12 elementos.",
                "Após sua leitura, colocar os seus elementos em ordem crescente.",
                "Depois ler um array B também com doze elementos,",
                "colocar os elementos de B em ordem decrescente.",
                "Construir um array C, onde cada elemento de C é a soma do elemento correspondente de A com B.",
                "Colocar em ordem crescente a matriz C e apresentar os seus valores."
            ));

            int[] a = new int[12] {15, 58, 21, 9, 30, 21, 28, 11, 36, 29, 42, 53};
            int[] b = new int[12] {19, 5, 45, 24, 35, 14, 12, 28, 39, 40, 8, 51};
            int[] c = new int[12];

            Array.Sort(a);
            foreach (int element in a) Console.Write($"{element}, ");
            Console.WriteLine("\n");

            Array.Sort(b);
            Array.Reverse(b);
            foreach (int element in b) Console.Write($"{element}, ");
            Console.WriteLine("\n");

            for (int i = 0; i < 12; i++) {
                c[i] = a[i] + b[i];
                Console.Write($"{c[i]}, ");
            }
 
            Console.ReadLine();
        }
    }
}