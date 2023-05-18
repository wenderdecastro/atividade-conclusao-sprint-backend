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
        public List<Marca> Listar()
        {
            foreach (var item in ListaMarca)
            {
                Console.WriteLine(@$"
            Codigo:           {item.Codigo}
            Nome da Marca:    {item.NomeMarca}
            Data do cadastro: {item.DataCadastro}");
            }
            return ListaMarca;
        }
        public string Cadastrar()
        {
            Console.WriteLine($"Por favor insira o nome da marca:");
            string nomeDaMarca = Console.ReadLine();
            Console.WriteLine($"Agora insira o codigo da marca (apenas números)");
            int codigoDaMarca = int.Parse(Console.ReadLine());
            ListaMarca.Add(
                new Marca(nomeDaMarca, codigoDaMarca)
            );
            return "Marca registrada!";
        }
        public string Deletar(Marca _marca)
        {
            Console.WriteLine($"Por favor insira o código da marca (apenas números)");
            int codigoDaMarca = int.Parse(Console.ReadLine());
            _marca = ListaMarca.Find(z => z.Codigo == codigoDaMarca);
            int index = ListaMarca.IndexOf(_marca);
            ListaMarca.RemoveAt(index);
            return "Produto deletado!";
        }
    }
}