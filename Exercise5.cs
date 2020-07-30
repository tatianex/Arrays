using System;

namespace arrays {
    class ExerciseFive {
        public static void Five(string[] args)
        {
            Console.WriteLine("Exercício 5.\nLeia um array A com 15 elementos.");
            Console.WriteLine("e calcule a média aritmética dos mesmos, em seguida,");
            Console.WriteLine("diga quantos dos elementos lidos estão abaixo, acima e na média.");

            int[] a = new int[15] {19, 11, 6, 14, 4, 21, 56, 36, 31, 45, 40, 37, 52, 28, 59};

            int sum = 0;
            double average = 0.0d;

            foreach (int value in a) sum += value;
            average = sum / a.Length;
            
            Console.WriteLine($"A soma dos elementos do array é igual a: {sum}");
            Console.WriteLine($"A média aritmética dos elementos é igual a: {average}");

            int belowAverage = 0;
            int aboveAverage = 0;
            int equalAverage = 0;
            
            foreach (int value in a) {
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