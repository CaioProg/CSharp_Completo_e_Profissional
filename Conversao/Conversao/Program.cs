using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Conversão Implícita
            //    byte num1 = 100; // 8 bits, de 0 a 255
            //    ushort num2; // 16 bits, 0 a 65.535

            //    float num3 = 1250.45f;
            //    double num4 = num3;

            //    num3 = num1;
            //    num2 = num1;

            //    char letra = 'C';
            //    int numero = 'C';

            //    Console.WriteLine(num2);
            //    Console.WriteLine(num3);
            //    Console.WriteLine(numero);
            #endregion

            #region Conversão Explícita
            //ushort num1 = 500;
            //byte num2 = (byte)num1;

            //float num3 = 2500.786f;
            //int num4 = (int)num3;

            //char letra = (char)97;
            #endregion

            #region Método Parse
            string txtNumero = "1985";

            int numero = int.Parse(txtNumero);

            byte num1 = byte.Parse("120");

            double num2 = double.Parse("123,34");

            float num3 = float.Parse("123,456");
            #endregion



            Console.WriteLine();
            
            Console.ReadKey();
        }
    }
}
