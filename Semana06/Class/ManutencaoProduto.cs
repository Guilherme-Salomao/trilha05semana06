using Semana06.Modulos;
using System;
using System.Collections.Generic;

namespace Semana06.Class
{
    internal class ManutencaoProduto : Menu
    {
        //CRIANÇÃO DA LISTA
        private List<Produto> produtos;

        //CONSTRUTOR
        public ManutencaoProduto(List<Produto> produtos)
        {
            this.produtos = produtos;
        }

        public void Cadastra()
        {
            Console.Clear();
            ExibirLogo();
            Console.WriteLine("\nDigite o nome do produto: ");
            string nomeProduto = Console.ReadLine();
            Produto produto = new Produto(nomeProduto);
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
            produtos.ForEach(p => Console.WriteLine(p.Nome));
            Console.WriteLine("\nAperte qualquer tecla para voltar!");
            Console.ReadKey();
        }

    }
}
