using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace atividade_conclusao_sprint_backend
{
    public class Usuario
    {
        List<Usuario> listaUsuario = new List<Usuario>();
        public int Codigo { get; private set; }
        public string NomeUsuario { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }
        public Login login { get; private set; }

        public bool Logado { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public Usuario()
        {
            NomeUsuario = "Andre";
            Senha = "1234567";
            Email = "andre@gmail.com";
            DataCadastro = DateTime.Now;
        }
        public Usuario(string _nomeUsuario, string _senhaUsuario, string _emailUsuario)
        {
            NomeUsuario = _nomeUsuario;
            Senha = _senhaUsuario;
            Email = _emailUsuario;
            DataCadastro = DateTime.Now;
        }
        public void Cadastrar()
        {
            Console.WriteLine($"Insira o nome de usuário: ");
            string NomeUsuario = Console.ReadLine();

            Console.WriteLine($"Digite o email");
            string email = Console.ReadLine();

            Console.WriteLine($"Agora vamos cadastrar a senha (min de 6 caracteres, max de 10 caracteres)");
            string senha = Console.ReadLine();

            listaUsuario.Add(
                new Usuario(NomeUsuario, senha, email)
            );
        }
        public void Listar()
        {
            foreach (var item in listaUsuario)
            {
                Console.WriteLine($"Nome:  {item.NomeUsuario}");
                Console.WriteLine($"Email: {item.Email}");
                Console.WriteLine($"Senha: ***********");

            }
        }
        public void Deletar()
        {
            Console.WriteLine($"Por favor insira o Email do Usuário");
            string emailUsuario = Console.ReadLine();
            Usuario _usuario = listaUsuario.Find(z => z.Email == emailUsuario);
            int index = listaUsuario.IndexOf(_usuario);
            listaUsuario.RemoveAt(index);
            Console.WriteLine($"Usuário deletado.");
            
        }
    }
}