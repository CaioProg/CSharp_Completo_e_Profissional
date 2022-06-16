using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Numericas Integrais
            //// Integral assinado
            //sbyte num1 = 10; // 8 bits, de -128 a 127
            //short num2 = 20; // 16 bits, -32.768 a 32.767
            //int num3 = 30; // 32 bits, -2.147.483 a 2.147.483.647
            //long num4 = 40L; // 64 bits, -9.223.372.036.854.775.808 a 9.223.372.036.854.775.807

            //// Integral sem sinal
            //byte num5 = 10; // 8 bits, intervalo de 0 a 255
            //ushort num6 = 20; // 16 bits, de 0 a 65.535
            //uint num7 = 30; // 32 bits, de 0 a 4.294.967.295
            //ulong num8 = 40L; // 64 bits, de 0 a 18.446.744.073.709.551.615

            //sbyte numero;
            //numero = 100;

            //numero = num1;
            #endregion

            #region Números Reais
            //float real1 = 100.75f; // 32 bits
            //double real2 = 500.754; // 64 bits
            //decimal real3 = 75223.538m; // 128 bits

            //double valor;
            //valor = real1;
            #endregion

            #region Caractere
            //char letra = '\u0061'; // char 'a'
            //char escape = '\n';
            //char literal = 'C';
            #endregion

            bool verificar = false;
            verificar = true;

            Console.WriteLine(verificar);
            Console.ReadKey();
        }
    }
}
