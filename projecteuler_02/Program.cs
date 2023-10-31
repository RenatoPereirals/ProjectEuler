using System;

namespace projecteuler_02 {
    internal class Program {
        static void Main(string[] args) {
            int limite = 4000000;
            int primeiro = 1;
            int segundo = 2;
            int soma = 0;

            Console.Write("Sequência de Fibonacci:\n");
            Console.Write(primeiro + ",\n" + segundo + ",\n");

            while (segundo <= limite) {
                if (segundo % 2 == 0) // Verifica se o número é par
                {
                    soma += segundo;
                }

                int proximo = primeiro + segundo;
                primeiro = segundo;
                segundo = proximo;

                if (segundo <= limite) {
                    Console.Write(segundo + ",\n");
                }
            }

            Console.WriteLine("\nSoma dos números pares da sequência de Fibonacci " +
                "que são inferiores a 4.000.000 é: " + soma);
        }
    }
}
