using System;

namespace arrays {
    class ExerciseOne {
        public static void One(string[] args)
        {
            Console.Write("Exercício 1.\nLeia dois arrays A e B com 15 elementos.\n");
            Console.WriteLine("Construir um array C, onde cada elemento de C é a subtração do elemento correspondente de A com B.\n");

            const int arraysLenght = 15;

            var a = new double[arraysLenght];
            var b = new double[arraysLenght];
            var c = new double[arraysLenght];

            for (int i = 0; i < arraysLenght; i++) {
                var isValidNumber = false;
                while (!isValidNumber) {
                    Console.WriteLine($"Informe o {i + 1}º número da primeira lista");
                    try {
                        a[i] = Double.Parse(Console.ReadLine());
                        isValidNumber = true;
                    }
                    catch (System.Exception) {
                        Console.WriteLine("Por favor informe um número válido.");
                    }
                }
            }
            
            Console.WriteLine("\n");

            for (int i = 0; i < arraysLenght; i++) {
                var isValidNumber = false;
                while (!isValidNumber) {
                    Console.WriteLine($"Informe o {i + 1}º número da segunda lista");
                    try {
                        b[i] = Double.Parse(Console.ReadLine());
                        isValidNumber = true;
                    }
                    catch (System.Exception) {
                        Console.WriteLine("Por favor informe um númeor válido.");
                    }
                }
            }

            Console.WriteLine("\nA primeira lista contém: ");
            foreach (double value in a) Console.Write($"{value}, ");
            Console.WriteLine("\nA segunda lista contém: ");
            foreach (double value in b) Console.Write($"{value}, ");

            Console.WriteLine("\nA terceira lista contém: ");
            for (int i = 0; i < arraysLenght; i++) {
                c[i] = a[i] - b[i];
                Console.Write($"{c[i]}, ");
            }

            Console.ReadLine();
        }
    }
}