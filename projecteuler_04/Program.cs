using System;

namespace projecteuler_04 {
    internal class Program {
        static void Main(string[] args) {
            int maiorPalidromo = 0;
            int produto = 0;
            int um = 0;
            int dois = 0;

            for (int i = 100; i <= 999; i++) {
                for (int j = 100; j <= 999; j++) {
                    produto = i * j;

                    if (produto == InverterNumero(produto) && produto > maiorPalidromo) {
                        maiorPalidromo = produto;
                        um = i;
                        dois = j;

                    }
                }
            }
            Console.WriteLine("O maior palíndromo feito do produto" +
                        " de três dígitos é: " + um + " x " + dois + " = " + maiorPalidromo);
        }

        static int InverterNumero(int numero) {
            string numeroString = numero.ToString();
            char[] caracteres = numeroString.ToCharArray();
            Array.Reverse(caracteres);
            string numeroInvertidoString = new string(caracteres);
            int numeroInvertido = int.Parse(numeroInvertidoString);

            return numeroInvertido;
        }
    }
}
