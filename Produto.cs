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
        public int Codigo { get; private set; }
        public float Preco { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public Marca Marca { get; private set; }
        Marca ObjMarca = new Marca();
        public List<Produto> ListaDeProdutos { get; private set; }
        public Produto()
        {

        }

        public Produto(string _nomeProduto, int _codigoProduto, float _precoProduto, Marca _marca, Usuario _usuario)
        {
            NomeProduto = _nomeProduto;
            Codigo = _codigoProduto;
            Preco = _precoProduto;
            DataCadastro = DateTime.Now;
            Marca = _marca;
            CadastradoPor = _usuario;
        }

        public string Cadastrar(Produto _produto)
        {
            Console.WriteLine($"\nQual seria o nome do produto?");
            string nomeProduto = Console.ReadLine();

            Console.WriteLine($"\nQual o código do produto?");
            int codigoProduto = int.Parse(Console.ReadLine());

            Console.WriteLine($"Qual o preço do produto?");
            float precoProduto = float.Parse(Console.ReadLine());

            Console.WriteLine($"Qual o código da marca?");
            int codigoMarca = int.Parse(Console.ReadLine());

            Console.WriteLine($"Produto cadastrado em: {DataCadastro}");

            return "";
        }
        public List<Produto> Listar()
        {
            return ListaDeProdutos;
        }
        public string Deletar(Produto _produto)
        {
            return "";
        }
    }
}