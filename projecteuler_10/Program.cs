using System;

namespace projecteuler_10 {
    internal class Program {
        static void Main(string[] args) {
            int numero = 2000000;
            long soma = EncontrarSomaPrimosAte(numero);
            Console.WriteLine("A soma dos números primos abaixo de " + numero + " é:" + soma);
        }

        static long EncontrarSomaPrimosAte(int numero) {
            bool[] ehPrimo = new bool[numero + 1];
            for (int i = 2; i <= numero; i++) {
                ehPrimo[i] = true;
            }

            for (int p = 2; p * p <= numero; p++) {
                if (ehPrimo[p]) {
                    for (int i = p * p; i <= numero; i += p) {
                        ehPrimo[i] = false;
                    }
                }
            }

            long soma = 0;
            for (int i = 2; i <= numero; i++) {
                if (ehPrimo[i]) {
                    soma += i;
                }
            }

            return soma;
        }
    }
}
