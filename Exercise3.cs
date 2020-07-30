using System;

namespace arrays {
    class ExerciseThree {
        public static void Three(string[] args)
        {
            Console.WriteLine("Exercício 3.\nLeia 10 elementos e armazene em um array A.");
            Console.WriteLine("Em seguida, solicite pelo teclado um número qualquer e pesquise no array se o número existe.");
            Console.WriteLine("Caso, seja verdade imprima a mensagem: “O número existe no array”");
            Console.WriteLine("caso contrário “Número inexistente”.\n");

            int[] a = new int[10] {19, 5, 45, 24, 35, 14, 12, 28, 39, 40};

            Console.WriteLine("Informe o número que deseja consultar: ");
            int request = Convert.ToInt32(Console.ReadLine());
            int index = Array.IndexOf(a, request);

            if (index != -1) {
                Console.WriteLine("O número existe no array");
            }
            else Console.WriteLine("Número inexistente");

            Console.ReadLine();
        }
    }
}