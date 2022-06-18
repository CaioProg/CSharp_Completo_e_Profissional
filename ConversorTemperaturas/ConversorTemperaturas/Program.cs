using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorTemperaturas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double c, f, k;

            Console.WriteLine("--- Conversor de Temperaturas ---");

            Console.Write("Insira a temperatura em Celcius: ");
            c = double.Parse(Console.ReadLine());

            Console.WriteLine("---------------------------------\n");

            // Calculo fahrenheit
            f = (c * 9 / 5) + 32;

            // Calculo  Kelvin
            k = c + 273.14;

            Console.WriteLine(c + " graus celcius equivale a " + f + " graus em fahrenheit e " + k + " em kelvin\n" );
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Precione qualquer tecla para finalizar a execução.");

            Console.ReadKey();
        }
    }
}
