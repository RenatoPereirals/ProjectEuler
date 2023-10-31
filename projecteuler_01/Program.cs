using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projecteuler_01 {
    internal class Program {
        static void Main(string[] args) {

             int soma = 0;

            for (int i = 0; i < 1000; i++) 
                { 
                if (i % 3 == 0 || i % 5 == 0) 
                    {
                        soma += i;
                    }
                }
            Console.WriteLine("A soma de todos os múltiplos de 3 ou 5 abaixo 1000 é: " + soma);
        }
    }
}
