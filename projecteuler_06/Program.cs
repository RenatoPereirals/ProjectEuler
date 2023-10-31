using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace prejeceuler_04 {
    internal class Program {
        static void Main(string[] args) {
            long somaDosQuadrados = 0;
            long quadradoDaSoma = 0;

            for (int i = 0; i <= 100; i++) {
                somaDosQuadrados += i * i;
            }

            for (int i = 0; i <= 100;i++) {
                quadradoDaSoma += i;
            }
            long resultado = quadradoDaSoma * quadradoDaSoma - somaDosQuadrados;
            Console.WriteLine("A soma dos quadrados dos primeiros cem números " +
                "naturais e o quadrado da soma é: " + resultado);
        }
    }
}
