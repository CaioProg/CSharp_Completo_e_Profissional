using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularIMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Minha calculadora
            Console.WriteLine("--- Calculadora de IMC ---\n");

            double peso, altura;

            Console.Write("Digite seu peso em Kg (Ex: 78,5): ");
            peso = double.Parse(Console.ReadLine());

            Console.Write("Digite sua altura em metros (Ex: 1,70): ");
            altura = double.Parse(Console.ReadLine());

            double imc = peso / (altura * altura);

            Console.WriteLine("\n------------ Resultado ------------");

            Console.WriteLine($"\nSeu IMC é: {imc}");

            if (imc < 18.5)
            {
                Console.WriteLine("\nVocê está abaixo do peso");
            }
            else if (imc >= 18.5 && imc < 24.9)
            {
                Console.WriteLine("\nVocê está com o peso ideal");
            }
            else if (imc <= 24.9 && imc < 30)
            {
                Console.WriteLine("\nVocê se encontra em pré-obesidade");
            }
            else
            {
                Console.WriteLine("\nVocê está obeso");
            }
            #endregion

            #region Calculadora do professor
            //Console.Write("Informe o peso em kg: ");
            //double peso = double.Parse(Console.ReadLine());

            //Console.Write("Informe a alura em metros");
            //double altura = double.Parse(Console.ReadLine());

            //double valorIMC = peso / (altura * altura);

            //if (valorIMC < 20)
            //{
            //    Console.WriteLine("\nIMC = " + valorIMC + " -> Abaixo do peso");
            //}
            //else if (valorIMC >= 20 && valorIMC <= 24)
            //{
            //    Console.WriteLine("\nIMC = " + valorIMC + " -> Peso normal");
            //}
            //else if (valorIMC >= 25 && valorIMC <= 29)
            //{
            //    Console.WriteLine("\nIMC = " + valorIMC + " -> Acima do peso");
            //}
            //else if (valorIMC >= 30 && valorIMC <= 34)
            //{
            //    Console.WriteLine("\nIMC = " + valorIMC + " -> Obeso");
            //}
            //else
            //{
            //    Console.WriteLine("\nIMC = " + valorIMC + " -> Muito Obeso");
            //}
            #endregion

            Console.ReadKey();

        }
    }
}
