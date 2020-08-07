using System;

namespace arrays {
    class ExerciseSix {
        public static void Six(string[] args)
        {
            Console.WriteLine(String.Join(
                Environment.NewLine,
                "\nExercício 6.",
                "Leia um array A com 12 elementos.",
                "Após sua leitura, colocar os seus elementos em ordem crescente.",
                "Depois ler um array B também com doze elementos,",
                "colocar os elementos de B em ordem decrescente.",
                "Construir um array C, onde cada elemento de C é a soma do elemento correspondente de A com B.",
                "Colocar em ordem crescente a matriz C e apresentar os seus valores.\n"
            ));

            const int arraysLenght = 3;

            var a = new double[arraysLenght];
            var b = new double[arraysLenght];
            var c = new double[arraysLenght];

            for (int i = 0; i < arraysLenght; i++) {
                Console.WriteLine($"Informe o {i + 1}º número da primeira lista");
                a[i] = Double.Parse(Console.ReadLine());
            }
            
            Console.WriteLine("\n");

            for (int i = 0; i < arraysLenght; i++) {
                Console.WriteLine($"Informe o {i + 1}º número da segunda lista");
                b[i] = Double.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nArray a. Em ordem crescente");
            Array.Sort(a);
            foreach (int value in a) Console.Write($"{value}, ");
            Console.WriteLine("\n");

            Console.WriteLine("Array b. Em ordem decrescente");
            Array.Sort(b);
            Array.Reverse(b);
            foreach (int value in b) Console.Write($"{value}, ");
            Console.WriteLine("\n");

            Console.WriteLine("Array c. Soma dos valores correspondentes de a + b em ordem crescente.");
            for (int i = 0; i < arraysLenght; i++) {
                c[i] = a[i] + b[i];
                Array.Sort(c);
                Console.Write($"{c[i]}, ");
            }
 
            Console.ReadLine();
        }
    }
}