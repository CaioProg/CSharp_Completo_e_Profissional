using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FatorialRecursivo
{
    class Program
    {
        static void Main(string[] args)
        {
            Inicio:
            Console.Clear();

            Console.WriteLine("### Calculadora Fatorial ###\n");

            Console.Write("Calcular fatorial de qual número? ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nO fatorial de {num} é {Fatorial(num)}");

            opinvalida:
            Console.Write("Deseja continuar calculando? s / n ");
            string op = Console.ReadLine();

            switch (op)
            {
                case "s":
                case "S":
                    goto Inicio;
                case "n":
                case "N":
                    break;
                default:
                    Console.WriteLine("Opção invalidada!");
                    goto opinvalida;
            }
        }

        static int Fatorial(int num)
        {
            if (num <= 0)
            {
                return 1;
            }
            return num * Fatorial(num - 1);
            // 5 * Fatorial(4);
            // 4 * Fatorial(3);
            // 3 * Fatorial(2);
            // 2 * Fatorial(1);
            // 1 * Fatorial(0);
            // return 1; 
        }
    }
}
