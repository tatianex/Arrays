using System;
using System.Linq;

namespace arrays {
    class ExerciseFour {
        public static void Four(string[] args)
        {
            Console.WriteLine("Exercício 4.\nLeia dois arrays A e B com 10 elementos.");
            Console.WriteLine("Em seguida, compare os arrays e verifique se os mesmos são iguais ou diferentes.\n");

            const int arraysLength = 3;

            var a = new double?[arraysLength];
            var b = new double[arraysLength];

            for (int i = 0; i < arraysLength; i++){
                Console.WriteLine($"Informe o {i + 1}º número do primeiro array");
                a[i] = Double.Parse(Console.ReadLine());
            }

            Console.WriteLine("\n");

            for (int i = 0; i < arraysLength; i++){
                Console.WriteLine($"Informe o {i + 1}º número do segundo array");
                b[i] = Double.Parse(Console.ReadLine());
            }

            foreach (int item in a) Console.Write($"{item}, ");
            Console.WriteLine("\n");

            foreach (int item in b) Console.Write($"{item}, ");
            Console.WriteLine("\n");

            var isEqual = false;
            var ArraysAreEqual = false;

            for (int i = 0; i < arraysLength; i++) {
                for (int j = 0; j < arraysLength; j++) {
                    if (a[i] == b[j]) {
                        isEqual = true;
                        a[i] = null;
                        break;
                    }
                }
            }

            if (!isEqual) ArraysAreEqual = false;

            var message = ArraysAreEqual ? "Os arrays são iguais." : "Os arrays são diferentes.";
            Console.WriteLine(message);

            Console.ReadLine();
        }
    }
}