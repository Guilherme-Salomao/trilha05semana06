using Semana06.Modulos;
using System;
using System.Collections.Generic;

namespace Semana06.Class
{
    internal class ManutencaoLivro : Menu
    {
        //CRIANDO A LISTA
        private List<Livro> livros;

        //CONSTRUTOR PARA A LISTA
        public ManutencaoLivro(List<Livro> livros)
        {
            {
                this.livros = livros;
            }
        }

        public void Cadastra()
        {
            Console.Clear();
            ExibirLogo();
            Console.WriteLine("\nDigite um livro: ");
            string nomeLivro = Console.ReadLine();
            Console.WriteLine("\nDigite o ISBN: ");
            string isbnLivro = Console.ReadLine();
            Livro livro = new Livro(nomeLivro, isbnLivro);
            livros.Add(livro);
            Console.WriteLine($"O livro: {nomeLivro}, com ISBN:  foi incluido com sucesso!");
            Console.WriteLine("Aperte qualquer tecla para voltar!");
            Console.ReadKey();
        }

        public void Lista()
        {
            Console.Clear();
            ExibirLogo();
            Console.WriteLine("\nLivros cadastrados:\n");
            livros.ForEach(l => Console.WriteLine(l.ObterDescricao()));
            Console.WriteLine("\nAperte qualquer tecla para voltar!");
            Console.ReadKey();
        }

    }
}
