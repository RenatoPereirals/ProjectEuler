using System;

namespace projecteuler_09 {
    internal class Program {
        static void Main(string[] args) {
            int produto = 0;

            for (int a = 1; a <= 1000; a++) {
                for (int b = a + 1; b <= 1000; b++) {
                    int c = 1000 - a - b;

                    if (a * a + b * b == c * c) {
                        produto = a * b * c;
                        break;
                    }
                }
            }

            Console.WriteLine("para uma tripla pitagórico para o qual a + b + c = 1000" +
                ", tem o produto (a x b x c) igual a: " + produto);
        }
    }
}

