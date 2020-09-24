using System;

namespace arrays {
    class ExerciseFive {
        public static void Five(string[] args)
        {
            Console.WriteLine("Exercício 5.\nLeia um array A com 15 elementos.");
            Console.WriteLine("e calcule a média aritmética dos mesmos, em seguida,");
            Console.WriteLine("diga quantos dos elementos lidos estão abaixo, acima e na média.");

            const int arrayLength = 15;
            var a = new double[arrayLength];
            double sum = 0;
            double average = 0.0d;

            for (int i = 0; i < arrayLength; i++) {
                Console.WriteLine($"Informe o {i + 1}º número da lista");
                a[i] = Double.Parse(Console.ReadLine());
            }

            foreach (double value in a) sum += value;
            average = sum / a.Length;
            
            Console.WriteLine($"A soma dos elementos do array é igual a: {sum}");
            Console.WriteLine($"A média aritmética dos elementos é igual a: {average}");

            int belowAverage = 0;
            int aboveAverage = 0;
            int equalAverage = 0;
            
            foreach (double value in a) {
                if (value < average) belowAverage++;
                else if (value > average) aboveAverage++;
                else equalAverage++;
            }

            Console.WriteLine($"Existem {belowAverage} elementos abaixo da média.");
            Console.WriteLine($"Existem {aboveAverage} elementos acima da média.");
            Console.WriteLine($"Existem {equalAverage} elementos na média.");

            Console.ReadLine();
        }
    }
}