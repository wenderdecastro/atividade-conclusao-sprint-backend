using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using atividade_conclusao_sprint_backend;

namespace atividade_conclusao_sprint_backend
{
    public class Produto
    {
        public Usuario CadastradoPor { get; private set; }
        public string NomeProduto { get; private set; }
        public string Codigo { get; private set; }
        public float Preco { get; private set; }
        public DateTime DataCadastro { get; private set; } = DateTime.Now;
        public Marca Marca { get; private set; }
        Marca ObjMarca = new Marca();
        public List<Produto> ListaDeProdutos = new List<Produto>();
        public Produto()
        {

        }

        public void Cadastrar()
        {

            Produto novoProduto = new Produto();

            Console.WriteLine($"\nQual seria o nome do produto?");
            novoProduto.NomeProduto = Console.ReadLine();

            Console.WriteLine($"\nQual o código do produto?");
            novoProduto.Codigo = Console.ReadLine();

            Console.WriteLine($"Qual o preço do produto?");
            novoProduto.Preco = float.Parse(Console.ReadLine());

            // Console.WriteLine($"Qual o código da marca?");
            // novoProduto.Marca = int.Parse(Console.ReadLine());

            Console.WriteLine($"Produto cadastrado em: {DataCadastro}");

            Console.WriteLine($"Produto cadastrado por: {CadastradoPor}");

            ListaDeProdutos.Add(novoProduto);

        }

        public void Listar()
        {
            if (ListaDeProdutos.Count() == 0)
            {
                Console.WriteLine($"Lista vazia..");
            }
            else
            {
                foreach (Produto p in ListaDeProdutos)
                {
                    Console.WriteLine(@$"------------------------
Codigo: {p.Codigo}
Nome: {p.NomeProduto}
Preco: {p.Preco}
Marca: 
Cadastro realizado por: {p.CadastradoPor}
------------------------");
                }
            }
        }
        
        public void Deletar()
        {
            Console.WriteLine($"Por favor insira o código do produto: ");
            string CodigoProduto = Console.ReadLine();
            Produto _produto = ListaDeProdutos.Find(z => z.Codigo == CodigoProduto);
            int index = ListaDeProdutos.IndexOf(_produto);
            ListaDeProdutos.RemoveAt(index);
            Console.WriteLine($"Produto deletado.");
        }
    }
}