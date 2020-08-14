using System;

namespace arrays {
    class ExerciseTwo {
        public static void Two(string[] args)
        {
            Console.WriteLine("\nLer um array com dez inteiros e mostrar os números na ordem direta e inversa que foram lidos.\n");

            const int arraysLenght = 10;

            var x = new double[arraysLenght];

            for (int i = 0; i < arraysLenght; i++) {
                var validNumber = false;
                while (!validNumber) {
                    Console.WriteLine($"Informe o {i + 1}º número");
                    try {
                        x[i] = Double.Parse(Console.ReadLine());
                        validNumber = true;
                    }
                    catch (System.Exception) {
                        Console.WriteLine("Por favor informe um número válido.");
                    }
                }
            }

            Console.WriteLine("\n");
            foreach (int element in x) Console.Write($"{element}, ");
            Console.WriteLine("\n");
            Array.Reverse(x);
            foreach (int element in x) Console.Write($"{element}, ");

            Console.ReadLine();
        }
    }
}