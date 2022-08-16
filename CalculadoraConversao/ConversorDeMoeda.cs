using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraConversao
{
    internal class ConversorDeMoeda
    {
        public static double Dolar;
        public static double Quantidade;
        public static double Iof = 6.0;

        public static double Conv() {
            return Dolar * Quantidade;
        }
        
        public static double Total() {
            double soma = Dolar * Quantidade;
            return soma + soma * Iof / 100.0;
        }
    }
}
