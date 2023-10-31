using System;
using System.Collections.Generic;

namespace EnesimoNumeroPrimo {
    class Program {
        static void Main(string[] args) {
            int n = 10001; // Defina o valor de 'n' para calcular o n-ésimo número primo
            int count = 0;
            int numero = 2;
            List<int> primos = new List<int>();

            while (count < n) {
                if (EhPrimo(numero)) {
                    primos.Add(numero);
                    count++;
                }
                numero++;
            }

            int enesimoPrimo = primos[n - 1];
            Console.WriteLine($"O {n}-ésimo número primo é: {enesimoPrimo}");
        }

        static bool EhPrimo(int numero) {
            if (numero < 2)
                return false;

            for (int i = 2; i <= Math.Sqrt(numero); i++) {
                if (numero % i == 0)
                    return false;
            }

            return true;
        }
    }
}
