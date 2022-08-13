using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colecoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
            // Array 
            string[] nomes = new string[3];
            nomes[0] = "Caio";
            nomes[1] = "Julia";
            nomes[2] = "Joca";

            // Lista Generica
            List<string> nomes2 = new List<string>();

            nomes2.Add("Lucas");
            nomes2.Add("Beatriz");
            nomes2.AddRange(nomes);

            //if (nomes2.Remove("Lucas"))
            //{
            //    MessageBox.Show("Lucas removido");
            //}
            //else
            //{
            //    MessageBox.Show("Não foi possivel remover.");
            //}

            //if (nomes2.Contains("Lucas"))
            //{
            //    MessageBox.Show("Contém");
            //}
            //else
            //{
            //    MessageBox.Show("Não Contém");
            //}

            //MessageBox.Show("Número de elementos: " + nomes2.Count);

            //nomes2.Sort();

            //MessageBox.Show("Julia está no índice: " + nomes2.IndexOf("Julia"));

            //nomes2.Insert(2, "João");

            //nomes2.RemoveAt(1);

            //nomes2.Clear();

            nomes2.Add("Lucas");

            foreach (string nome in nomes2)
            {
                lista.Items.Add(nome);
            }
        }

        private void btnHashSet_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();

            HashSet<string> veiculos = new HashSet<string>()
            {
                "Carro", "Moto", "Avião", "Helicoptero", "Barco"
            };

            //MessageBox.Show(veiculos.ElementAt(2));

            //if (veiculos.Add("Carro"))
            //{
            //    MessageBox.Show("Item adicionado");
            //}
            //else
            //{
            //    MessageBox.Show("Item não adicionado");
            //}

            //if (veiculos.Contains("Cartro"))
            //{
            //    MessageBox.Show("Contem.");
            //}
            //else
            //{
            //    MessageBox.Show("Não Contem.");
            //}

            //veiculos.Remove("");
            //int num = veiculos.Count;
            //veiculos.Clear();
            //veiculos.First();
            //veiculos.Last();


            foreach (string item in veiculos)
            {
                lista.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<int, string> alunos = new Dictionary<int, string>()
            {
                { 150, "Lucas" },
                { 200, "Caio" },
                { 80, "Caio" }
            };

            alunos.Add(100, "Gabi");

            //alunos.ContainsKey(150)
            //if (alunos.ContainsKey(150))
            //{
            //    MessageBox.Show("Contém");
            //}
            //else
            //{
            //    MessageBox.Show("Não Contém");
            //}

            if (alunos.ContainsValue("Caio"))
            {
                MessageBox.Show("Contém");
            }
            else
            {
                MessageBox.Show("Não Contém");
            }

            //alunos.Remove(80);

            //alunos.Clear();

            //KeyValuePair<int, string> primeiro = alunos.First();
            //MessageBox.Show($"Primeiro: {primeiro.Value}");

            //MessageBox.Show($"Último: {alunos.Last().Key} {alunos.Last().Value}");

            foreach (KeyValuePair<int, string> item in alunos)
            {
                lista.Items.Add(item.Key + " = " + item.Value);
            }

            //MessageBox.Show($"Quantidade de alunos é: {alunos.Count}");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            lista.Items.Clear();
            SortedList<int, string> alunos = new SortedList<int, string>()
            {
                { 27, "Danny" },
                { 10, "Julia" },
                { 17, "Maria" }
            };
            alunos.Add(45, "Caio");

            //alunos.Reverse();

            //alunos.Remove(17);
            //alunos.RemoveAt(0);
            //alunos.Count;
            //alunos.ContainsKey(10);
            //alunos.ContainsValue("Danny");


            foreach (KeyValuePair <int, string> item in alunos)
            {
                lista.Items.Add(item.Key + " " + item.Value);
            }
        }

        private void btnSortedLDictionary_Click(object sender, EventArgs e)
        {
            SortedDictionary<int, string> alunos = new SortedDictionary<int, string>()
            {
                {23, "Lucas" },
                {13424, "Maria" },
                {13425, "Ana" }
            };

            alunos.Add(233, "Julia");

            //alunos.Remove(13423);
            //alunos.Count;
            //alunos.Clear();
            //alunos.ContainsKey(212);
            //alunos.ContainsValue("Lucas");
            MessageBox.Show(alunos.ElementAt(0).ToString());
            

            foreach (KeyValuePair<int,string> item in alunos.Reverse())
            {
                lista.Items.Add(item);
            }
        }

        private void btnSortedSet_Click(object sender, EventArgs e)
        {

            lista.Items.Clear();
            SortedSet<string> nomes = new SortedSet<string>()
            {
                "Caio", "Danny", "Julia", "Maria"
            };

            if (!nomes.Add("Lucas"))
            {
                MessageBox.Show("Não pode repetir o valor!");
            }

            //nomes.Reverse();
            //nomes.Remove("Flávio");
            //nomes.ElementAt(1);
            //nomes.First();
            //nomes.Last();
            //nomes.Count();
            //nomes.Clear();

            MessageBox.Show(nomes.First());

            foreach (string nome in nomes)
            {
                lista.Items.Add(nome);
            }
        }
    }
}