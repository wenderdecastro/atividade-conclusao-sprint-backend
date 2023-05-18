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

            do
            {

                Console.WriteLine(@$"
------------------------
Menu de login

[1] - Cadastrar Usuário
[2] - Logar Usuário
[4] - Listar Usuários
[5] - Deletar Usuário

[0] - Sair
------------------------");

                ConsoleKeyInfo opcao = Console.ReadKey(true);

                switch (opcao.Key)
                {
                    case ConsoleKey.D1:
                        usuario.Cadastrar();
                        break;
                    case ConsoleKey.D2:
                        Logar();
                        break;
                    case ConsoleKey.D3:
                        usuario.Listar();
                        break;
                    case ConsoleKey.D4:
                        usuario.Deletar();
                        break;
                    case ConsoleKey.D0:
                        Environment.Exit(0);
                        break;
                }
            } while (Logado == false);
            Menu();

        }
        public string Logar()
        {

            Console.WriteLine($"\n\nLOGIN");

            Console.WriteLine($"\nDigite o nome do usuário: ");
            logarUsuario = Console.ReadLine();

            Console.WriteLine($"\nDigite a senha do usuário: ");
            logarSenha = Console.ReadLine();

            if ((logarUsuario == usuario.NomeUsuario) && (logarSenha == usuario.Senha))
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

                ConsoleKeyInfo opcao = Console.ReadKey(true);

                switch (opcao.Key)
                {
                    case ConsoleKey.D1:
                        produto.Cadastrar();
                        break;
                    case ConsoleKey.D2:
                        produto.Listar();
                        break;
                    case ConsoleKey.D3:
                        produto.Deletar();
                        break;
                    case ConsoleKey.D4:
                        marca.Cadastrar();
                        break;
                    case ConsoleKey.D5:
                        marca.Listar();
                        break;
                    case ConsoleKey.D6:
                        marca.Deletar();
                        break;
                    case ConsoleKey.D0:
                        Environment.Exit(0);
                        break;
                }

            } while (true);
        }
    }
}