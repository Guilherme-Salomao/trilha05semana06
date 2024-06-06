using Semana06.Modulos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana06.Class
{
    internal class Livro : Produto
    {
        public string ISBN { get; set; }
        public int TotalDePaginas { get; set; }

        //Construtor
        public Livro(string nome, string isbn) : base(nome)
        {
            ISBN = isbn;
        }

        public string ObterDescricao()
        {
            return $"Nome do livro: {Nome}, ISBN: {ISBN}";
        }

    }
}
