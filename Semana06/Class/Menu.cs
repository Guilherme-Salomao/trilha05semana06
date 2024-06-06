using Semana06.Modulos;
using System;
using System.Collections.Generic;

namespace Semana06.Class
{
    internal class Menu
    {
        public void ExibirLogo()
        {
            Console.WriteLine(@"
░██████╗███████╗███╗░░░███╗░█████╗░███╗░░██╗░█████╗░  ░█████╗░░█████╗░
██╔════╝██╔════╝████╗░████║██╔══██╗████╗░██║██╔══██╗  ██╔══██╗██╔═══╝░
╚█████╗░█████╗░░██╔████╔██║███████║██╔██╗██║███████║  ██║░░██║██████╗░
░╚═══██╗██╔══╝░░██║╚██╔╝██║██╔══██║██║╚████║██╔══██║  ██║░░██║██╔══██╗
██████╔╝███████╗██║░╚═╝░██║██║░░██║██║░╚███║██║░░██║  ╚█████╔╝╚█████╔╝
╚═════╝░╚══════╝╚═╝░░░░░╚═╝╚═╝░░╚═╝╚═╝░░╚══╝╚═╝░░╚═╝  ░╚════╝░░╚════╝░");
        }

        //LISTAS CRIADAS
        private List<Produto> produtos = new List<Produto>();
        private List<Livro> livros = new List<Livro>();

        public void ExibirMenu()
        {
            while (true)
            {
                Console.Clear();
                ExibirLogo();
                Console.WriteLine("\nDigite 1 para registrar um Produto");
                Console.WriteLine("Digite 2 para listar os Produtos");
                Console.WriteLine("Digite 3 para Registrar um Livro");
                Console.WriteLine("Digite 4 para listar os Livros");
                Console.WriteLine("Digite -1 para sair");
                Console.Write("\nDigite a sua opção: ");
                string opcaoEscolhida = Console.ReadLine();
                int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

                switch (opcaoEscolhidaNumerica)
                {
                    case 1:
                        ManutencaoProduto cadastraProduto = new ManutencaoProduto(produtos);
                        cadastraProduto.Cadastra();
                        break;
                    case 2:
                        ManutencaoProduto listaProduto = new ManutencaoProduto(produtos);
                        listaProduto.Lista();
                        break;
                    case 3:
                        ManutencaoLivro cadastraLivro = new ManutencaoLivro(livros);
                        cadastraLivro.Cadastra();
                        break;
                    case 4:
                        ManutencaoLivro listaLivro = new ManutencaoLivro(livros);
                        listaLivro.Lista();
                        break;
                    case -1:
                        Console.WriteLine("Tchau tchau :)");
                        return;
                    default:
                        Console.WriteLine("Opção inválida");
                        Console.ReadKey();
                        break;
                }
            }
        }

    }
}
