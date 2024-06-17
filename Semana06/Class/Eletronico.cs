using Semana06.Modulos;

namespace Semana06.Class
{
    internal class Eletronico : Produto
    {
        public int Voltagem { get; set; }
        public int Potencia { get; set; }

        public Eletronico(string title, string description) : base(title, description)
        {
        }

    }
}
