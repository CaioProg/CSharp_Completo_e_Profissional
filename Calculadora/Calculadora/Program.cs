using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Inicio:

            Console.Clear();

            Console.WriteLine("--- Calculadora ---\n");

            Console.Write("Digite o primeiro número: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double num2 = double.Parse(Console.ReadLine());

        OpInvalida:
            Console.Write("Escolha a operação (+ - x /):");
            char op = char.Parse(Console.ReadLine());

            double resultado = 0;

            switch (op)
            {

                case '+':
                    resultado = num1 + num2;
                    Console.Write($"\nO resultado da soma é: {resultado}");
                    break;
                case '-':
                    resultado = num1 - num2;
                    Console.Write($"\nO resultado da subtração é: {resultado}");
                    break;
                case 'x':
                case '*':
                case 'X':
                    resultado = num1 * num2;
                    Console.Write($"\nO resultado da multiplicação é: {resultado}");
                    break;
                case ':':
                case '/':
                    if (num2 == 0)
                    {
                        Console.WriteLine("\nNão é possivél dividir por 0.");
                    }
                    else
                    {
                        resultado = num1 / num2;
                        Console.Write($"\nO resultado da divisão é: {resultado}");
                    }
                    break;
                default:
                    Console.WriteLine("Erro, opção invalida!");
                    goto OpInvalida;

            }

            Console.WriteLine("\n\nContinuar calculando (s / n) ?");
            string opcao = Console.ReadLine();

            if (opcao == "s" || opcao == "S")
            {
                goto Inicio;
            }
        }
    }
}