using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace atividade_conclusao_sprint_backend
{
    public class Marca
    {

        public int Codigo { get; private set; }
        public string NomeMarca { get; private set; }
        public DateTime DataCadastro { get; private set; }
        List<Marca> ListaMarca = new List<Marca>();
        public Marca()
        {
        }
        public Marca(string _nomeMarca, int _codigoMarca)
        {
            NomeMarca = _nomeMarca;
            Codigo = _codigoMarca;
            DataCadastro = DateTime.Now;
        }
        public void Listar()
        {
            foreach (var item in ListaMarca)
            {
                Console.WriteLine(@$"
Codigo:           {item.Codigo}
Nome da Marca:    {item.NomeMarca}
Data do cadastro: {item.DataCadastro}");
            }
        }
        public void Cadastrar()
        {
            Console.WriteLine($"Por favor insira o nome da marca: ");
            string nomeDaMarca = Console.ReadLine();
            Console.WriteLine($"Insira o codigo da marca: ");
            int codigoDaMarca = int.Parse(Console.ReadLine());
            ListaMarca.Add(
                new Marca(nomeDaMarca, codigoDaMarca)
            );
            Console.WriteLine($"Marca cadastrada.");

        }
        public void Deletar()
        {
            Console.WriteLine($"Insira o código da marca.");
            int codigoDaMarca = int.Parse(Console.ReadLine());
            Marca marca = ListaMarca.Find(z => z.Codigo == codigoDaMarca);
            int index = ListaMarca.IndexOf(marca);
            ListaMarca.RemoveAt(index);
            Console.WriteLine($"Marca deletada.");
        }
    }
}