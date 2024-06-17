using Semana06.Modulos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Semana06.Class
{
    internal class ManutencaoProduto : Menu
    {
        //CRIANÇÃO DA LISTA
        private List<Produto> produtos;

        //CONSTRUTOR
        public ManutencaoProduto(List<Produto> produtos)
        {
            this.produtos = produtos ?? new List<Produto>();
        }

        public void Cadastra()
        {
            Console.Clear();
            ExibirLogo();
            Console.WriteLine("\nDigite o nome do produto: ");
            string nomeProduto = Console.ReadLine();
            Console.WriteLine("\nDigite o descrição do produto: ");
            string descricaoProduto = Console.ReadLine();
            Produto produto = new Produto(nomeProduto, descricaoProduto);
            produtos.Add(produto);
            Console.WriteLine($"O produto {nomeProduto} foi incluído com sucesso!");
            Console.WriteLine("Aperte qualquer tecla para voltar!");
            Console.ReadKey();
        }

        public void Lista()
        {
            Console.Clear();
            ExibirLogo();
            Console.WriteLine("\nProdutos cadastrados:\n");
            produtos.ForEach(p => Console.WriteLine($"{p.Nome} - {p.PrecoUnitario:C} - {p.Descricao}"));
            Console.WriteLine("\nAperte qualquer tecla para voltar!");
            Console.ReadKey();
            Console.Clear();
            ExibirLogo();
            ExibirMenu();
        }

        public void ListarProdutos()
        {
            Console.Clear();
            ExibirLogo();
            Console.WriteLine("\nProdutos cadastrados:\n");

            foreach (var produto in produtos)
            {
                Console.WriteLine($"ID: {produto.Codigo}");
                Console.WriteLine($"Nome: {produto.Nome}");
                Console.WriteLine($"Preço: {produto.PrecoUnitario:C2}");
                Console.WriteLine($"Descrição: {produto.Descricao}");
                Console.WriteLine("----------------------------------------");
            }

            Console.WriteLine("\nAperte qualquer tecla para voltar!");
            Console.ReadKey();
            Console.Clear();
            ExibirLogo();
            ExibirMenu();
        }

        public void OrdenarPorPreco()
        {
            produtos = produtos.OrderBy(p => p.PrecoUnitario).ToList();
            ExibirProdutosOrdenados("preço");
        }

        public void OrdenarPorTitulo()
        {
            produtos = produtos.OrderBy(p => p.Nome).ToList();
            ExibirProdutosOrdenados("título");
        }

        public void ExibirProdutosOrdenados(string criterio)
        {
            Console.Clear();
            ExibirLogo();
            Console.WriteLine($"\nLista de Produtos Ordenados por {criterio}:\n");

            // Exibir cada produto ordenado
            foreach (var produto in produtos)
            {
                Console.WriteLine($"ID: {produto.Codigo}");
                Console.WriteLine($"Nome: {produto.Nome}");
                Console.WriteLine($"Preço: {produto.PrecoUnitario:C2}"); // Mostra o preço formatado como moeda
                Console.WriteLine($"Descrição: {produto.Descricao}");
                Console.WriteLine("----------------------------------------");
            }

            Console.WriteLine("\nAperte qualquer tecla para voltar ao menu.");
            Console.ReadKey();
        }

        public async Task ListarProdutosExternos()
        {
            ApiClient apiClient = new ApiClient();
            List<Produto> produtosExternos = await apiClient.ConsultarApiExternaAsync();

            if (produtosExternos != null && produtosExternos.Any())
            {
                // Limpa a lista atual e adiciona os produtos externos
                produtos.Clear();
                produtos.AddRange(produtosExternos);

                Console.Clear();
                ExibirLogo();
                Console.WriteLine("\nProdutos da API externa:\n");

                foreach (var produto in produtos)
                {
                    Console.WriteLine($"ID: {produto.Codigo}");
                    Console.WriteLine($"Nome: {produto.Nome}");
                    Console.WriteLine($"Preço: {produto.PrecoUnitario:C2}");
                    Console.WriteLine($"Descrição: {produto.Descricao}");
                    Console.WriteLine("----------------------------------------");
                }
            }
            else
            {
                Console.WriteLine("Não foi possível obter produtos da API externa.");
            }

            Console.WriteLine("\nAperte qualquer tecla para voltar ao menu.");
            Console.ReadKey();
        }
    }
}