using Semana06.Modulos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

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
        private List<Cliente> clientes = new List<Cliente>();
 


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
                Console.WriteLine("Digite 5 para Registrar um Cliente");
                Console.WriteLine("Digite 6 para listar os Clientes");
                Console.WriteLine("Digite 7 API");
                Console.WriteLine("Digite 8 Lista de Produtos por Título");
                Console.WriteLine("Digite 9 Lista de Produtos por Preço");
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
                    case 5:
                        ManutencaoCliente cadastraCliente = new ManutencaoCliente(clientes);
                        cadastraCliente.Cadastra();
                        break;
                    case 6:
                        ManutencaoCliente listaCliente = new ManutencaoCliente(clientes);
                        listaCliente.Lista();
                        break;
                    case 7:
                        ManutencaoProduto listarProdutosExternos = new ManutencaoProduto(produtos);
                        listarProdutosExternos.ListarProdutosExternos().GetAwaiter().GetResult();
                        break;
                    case 8:
                        ManutencaoProduto ordenaPorTitulo = new ManutencaoProduto(produtos);
                        ordenaPorTitulo.OrdenarPorTitulo();
                        break;
                    case 9:
                        ManutencaoProduto ordenaPorPreco = new ManutencaoProduto(produtos);
                        ordenaPorPreco.OrdenarPorPreco();
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
