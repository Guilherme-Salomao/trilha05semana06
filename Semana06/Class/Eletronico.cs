using Semana06.Modulos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana06.Class
{
    internal class Eletronico : Produto
    {
        int voltagem;
        int potencia;

        public Eletronico(string nome) : base(nome)
        {
        }
    }
}
