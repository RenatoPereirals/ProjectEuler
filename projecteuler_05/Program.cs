using System;

namespace MinimoMultiploComum {
    class Program {
        static void Main(string[] args) {
            int[] numeros = new int[19];

            for (int i = 1; i <= numeros.Length; i++) {
                numeros[i - 1] = i;
            }

            int mmc = CalcularMMC(numeros);
            Console.WriteLine("O MMC dos números é: " + mmc);
        }

        // Função para calcular o MDC usando o Algoritmo de Euclides
        static int CalcularMDC(int a, int b) {
            while (b != 0) {
                int resto = a % b;
                a = b;
                b = resto;
            }
            return a;
        }

        // Função para calcular o MMC de vários números
        static int CalcularMMC(int[] numeros) {
            int mmc = numeros[0];
            for (int i = 1; i < numeros.Length; i++) {
                mmc = (mmc * numeros[i]) / CalcularMDC(mmc, numeros[i]);
            }
            return mmc;
        }
    }
}
