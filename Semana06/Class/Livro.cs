﻿using Semana06.Modulos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana06.Class
{
    internal class Livro : Produto
    {
        String isbn;
        int totalDePaginas;

        public Livro(string nome) : base(nome)
        {
        }
    }
}
