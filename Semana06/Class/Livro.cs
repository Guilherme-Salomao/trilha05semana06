using Semana06.Modulos;


namespace Semana06.Class
{
    internal class Livro : Produto
    {
        public string ISBN { get; set; }
        public int TotalDePaginas { get; set; }

        //Construtor
        public Livro(string nome, string description, string isbn) : base(nome, description)
        {
            ISBN = isbn;
        }

        public string ObterDescricao()
        {
            return $"Nome do livro: {Nome}, ISBN: {ISBN}";
        }

    }
}
