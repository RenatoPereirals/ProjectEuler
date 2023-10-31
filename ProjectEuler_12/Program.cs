using System;
using System.Collections.Generic;

namespace projecteuler_12 
{
    internal class Program 
    {
        static void Main(string[] args) 
        {
            int number = 1;
            int triangularNumber = 1;

            while (true) {
                int divisorCount = GetDivisorCount(triangularNumber);

                if (divisorCount >= 500) {
                    Console.WriteLine($"O primeiro número triangular com 500 ou mais divisores é: {triangularNumber}");
                    break;
                }

                number++;
                triangularNumber += number;
            }
        }

        static int GetDivisorCount(int number) 
        {
            int count = 0;
            int sqrt = (int)Math.Sqrt(number);

            for (int i = 1; i <= sqrt; i++) 
            {
                if (number % i == 0) 
                {
                    count += 2; // Conta i e (number / i) como divisores
                }
            }

            // Se o número é um quadrado perfeito, subtrai 1 do contador
            if (sqrt * sqrt == number) 
            {
                count--;
            }

            return count;
        }
    }
}