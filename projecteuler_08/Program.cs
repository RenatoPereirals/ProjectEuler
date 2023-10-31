using System;
using System.Collections.Generic;

namespace projecteuler_08 {
    internal class Program {
        static void Main(string[] args) {
            string digitoString = "7316717653133062491922511967442657474235534919493496983520312774506326239578318016984801869478851843858615607891129494954595017379583319528532088055111254069874715852386305071569329096329522744304355766896648950445244523161731856403098711121722383113622298934233803081353362766142828064444866452387493035890729629049156044077239071381051585930796086670172427121883998797908792274921901699720888093776657273330010533678812202354218097512545405947522435258490771167055601360483958644670632441572215539753697817977846174064955149290862569321978468622482839722413756570560574902614079729686524145351004748216637048440319989000889524345065854122758866688116427171479924442928230863465674813919123162824586178664583591245665294765456828489128831426076900422421902267105562632111110937054421750694165896040807198403850962455444362981230987879927244284909188845801561660979191338754992005240636899125607176060588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450";

            // Chamamos a função CalcularMaiorProduto para encontrar o maior produto de 13 dígitos adjacentes
            Console.WriteLine(CalcularMaiorProduto(digitoString, 13));
        }

        static long CalcularMaiorProduto(string digitoString, int digitosAdjacentes) {
            long maiorProduto = 0;
            Queue<int> nums = new Queue<int>();

            // Inicializa a variável prod com o produto dos primeiros digitosAdjacentes dígitos
            long prod = 1;
            for (int j = 0; j < digitosAdjacentes; j++) {
                int digito = int.Parse(digitoString[j].ToString());
                nums.Enqueue(digito);
                prod *= digito;
            }

            // Loop para calcular o maior produto
            int i = digitosAdjacentes;
            while (i < digitoString.Length) {
                // Verifica se a fila não está vazia antes de chamar Dequeue()
                if (nums.Count > 0) {
                    int last = nums.Dequeue();
                    if (last != 0) {
                        prod /= last; // Remove o valor do último dígito da fila do produto
                    }
                    else {
                        // Se o valor removido for 0, precisamos recalcular o produto
                        prod = 1;
                        foreach (int num in nums) {
                            prod *= num;
                        }
                    }
                }

                // Continua pegando os próximos dígitos
                int next = int.Parse(digitoString[i++].ToString());
                nums.Enqueue(next);
                if (next != 0) {
                    prod *= next; // Multiplica o novo valor na fila com o produto atual
                }
                else {
                    // Se o novo valor for 0, precisamos recalcular o produto
                    prod = 1;
                    foreach (int num in nums) {
                        prod *= num;
                    }
                }

                // Verifica se o produto calculado é maior que o maior produto encontrado até o momento
                if (prod > maiorProduto) {
                    maiorProduto = prod;
                }
            }

            // Retornamos o maior produto encontrado
            return maiorProduto;
        }
    }
}
