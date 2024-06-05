using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana06.Modulos
{
    internal class Produto
    {
        private string nome;
        private string descriao;
        private double precoUnitario;
        private int quantidade;

        // Propriedades públicas para acessar e modificar os atributos privados
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        // Construtor que exige um nome
        public Produto(string nome)
        {
            Nome = nome;
        }
    }
}
