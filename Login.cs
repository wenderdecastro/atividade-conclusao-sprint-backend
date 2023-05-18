using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace atividade_conclusao_sprint_backend
{
    public class Login
    {
        Usuario usuario = new Usuario();
        Produto produto = new Produto();
        Marca marca = new Marca();
        List<Marca> listaMarca = new List<Marca>();
        public string logarUsuario { get; private set; }
        public string logarSenha { get; private set; }
        public bool Logado { get; private set; }
        public Login(bool _logado)
        {
            Logado = _logado;
        }
        public string Logar()
        {
            Console.WriteLine($"Digite o nome do usuário: ");
            logarUsuario = Console.ReadLine();

            Console.WriteLine($"Digite a senha do usuário: ");
            logarSenha = Console.ReadLine();

            if (logarUsuario == usuario.NomeUsuario && logarSenha == usuario.Senha)
            {
                Logado = true;
                Console.WriteLine($"Login Efetuado");
            }
            else
            {
                Logado = false;
                Console.WriteLine($"Nome ou senha incorretos.");
            }

            return "";
        }

        public string Deslogar(Usuario _usuario)
        {
            return "";
        }

        public void Menu()
        {
            do
            {
                Console.WriteLine(@$"
            ------------------------
            Menu do administrador
            
            [1] - Cadastrar Produto
            [2] - Listar Produtos
            [3] - Deletar Produtos
            [4] - Cadastrar Marca
            [5] - Listar Marcas
            [6] - Deletar Marcas

            [0] - Sair
            ------------------------");

                ConsoleKeyInfo opcao = Console.ReadKey();

                switch (opcao.Key)
                {
                    case ConsoleKey.D1:
                        break;
                    case ConsoleKey.D2:
                        break;
                    case ConsoleKey.D3:
                        break;
                    case ConsoleKey.D4:
                        marca.Cadastrar();
                        break;
                    case ConsoleKey.D5:
                        break;
                    case ConsoleKey.D6:
                        break;
                    case ConsoleKey.D0:
                        break;
                }

            } while(true);
        }
    }
}