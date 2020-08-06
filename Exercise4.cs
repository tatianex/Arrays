using System;
using System.Linq;

namespace arrays {
    class ExerciseFour {
        public static void Four(string[] args)
        {
            Console.WriteLine("Exercício 4.\nLeia dois arrays A e B com 10 elementos.");
            Console.WriteLine("Em seguida, compare os arrays e verifique se os mesmos são iguais ou diferentes.\n");

            var a = new double[10];
            var b = new double[10];

            for (int i = 0; i < a.Length; i++){
                Console.WriteLine($"Informe o {i + 1}º número");
                var result = Double.Parse(Console.ReadLine());
                a[i] = result;
            }

            Console.WriteLine("\n");

            for (int i = 0; i < b.Length; i++){
                Console.WriteLine($"Informe o {i + 1}º número");
                var result = Double.Parse(Console.ReadLine());
                b[i] = result;
            }

            foreach (int item in a) Console.Write($"{item}, ");
            Console.WriteLine("\n");

            foreach (int item in b) Console.Write($"{item}, ");
            Console.WriteLine("\n");

            bool isEqual = Enumerable.SequenceEqual(a, b);

            if (isEqual == true) Console.WriteLine("São iguais.");
            else Console.WriteLine("São diferentes.");

            Console.ReadLine();
        }
    }
}