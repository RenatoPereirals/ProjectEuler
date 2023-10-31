using System;

namespace EncontrarMaiorFatorPrimo {
    class Program {
        static void Main(string[] args) {
            long numero = 600851475143;
            long fatorPrimo = EncontrarMaiorFatorPrimo(numero);

            Console.WriteLine("O maior fator primo de " + numero + " é: " + fatorPrimo);
        }

        static long EncontrarMaiorFatorPrimo(long numero) {
            long fator = 2;
            long ultimoFator = 1;

            // Tratar os fatores de 2 separadamente
            while (numero % 2 == 0) {
                numero /= 2;
                ultimoFator = 2;
            }
            
            // Verificar os próximos fatores ímpares
            for (fator = 3; fator <= Math.Sqrt(numero); fator += 2) {
                while (numero % fator == 0) {
                    numero /= fator;
                    ultimoFator = fator;
                }
            }

            // Se o número restante é maior que 2, ele também é um fator primo
            if (numero > 2) {
                ultimoFator = numero;
            }

            return ultimoFator;
        }
    }
}
