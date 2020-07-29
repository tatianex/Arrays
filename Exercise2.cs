using System;

namespace arrays {
    class ExerciseTwo {
        public static void Two(string[] args)
        {
            Console.WriteLine("Ler um array com dez inteiros e mostrar os números na ordem direta e inversa que foram lidos.");

            int[] x = new int[10] {58, 21, 9, 30, 21, 28, 44, 29, 52, 53};

            foreach (int element in x) Console.Write($"{element}, ");

            Console.WriteLine("\n");

            Array.Reverse(x);

            foreach (int element in x) Console.Write($"{element}, ");

            Console.ReadLine();
        }
    }
}