using System;
using System.Text;

namespace arrays {
    class ExerciseOne {
        public static void One(string[] args)
        {
            Console.Write("Exercício 1.\nLeia dois arrays A e B com 15 elementos.\n");
            Console.WriteLine("Construir um array C, onde cada elemento de C é a subtração do elemento correspondente de A com B.\n");

            const int arraysLenght = 5;

            var a = new double[arraysLenght];
            var b = new double[arraysLenght];
            var c = new double[arraysLenght];
            var outputc = new StringBuilder();

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
                        Console.WriteLine("Por favor informe um número válido.");
                    }
                }
            }

            for (int i = 0; i < arraysLenght; i++) {
                c[i] = a[i] - b[i];
                outputc.Append($"{c[i]} ");
            }

            Console.WriteLine("\nA terceira lista contém: ");
            Console.WriteLine(outputc);

            Console.ReadLine();
        }
    }
}