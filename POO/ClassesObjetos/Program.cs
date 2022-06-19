using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Classes e Objetos
            //MinhaClasse mClasse = new MinhaClasse();
            //MinhaClasse m2 = null;

            //OutraClasse outra = new OutraClasse();
            //OutraClasse outra2 = outra;
            #endregion

            Pessoa p1 = new Pessoa();
            p1.nome = "Caio";
            p1.sobrenome = "Lucas";
            p1.anoNascimento = 2002;

            Pessoa p2 = new Pessoa()
            {
                nome = "Maria",
                sobrenome = "Silva",
                anoNascimento = 1978
            };

            p1.nome = "Logan";

            Console.WriteLine($"Pessoa 1: {p1.nome}");
            Console.WriteLine($"Pessoa 1: {p1.sobrenome}");
            Console.WriteLine($"Pessoa 1: {p1.anoNascimento}");
            p1.Cumprimentar();

            Console.WriteLine();

            Console.WriteLine($"Pessoa 2: {p2.nome}");
            Console.WriteLine($"Pessoa 2: {p2.sobrenome}");
            Console.WriteLine($"Pessoa 2: {p2.anoNascimento}");
            p2.Cumprimentar();

            Console.ReadKey();
        }
    }

    class MinhaClasse
    {

    }
}
