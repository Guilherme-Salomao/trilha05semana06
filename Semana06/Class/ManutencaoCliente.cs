using Semana06.Modulos;
using System;
using System.Collections.Generic;

namespace Semana06.Class
{
    internal class ManutencaoCliente : Menu
    {
        //CRIANDO A LISTA
        private List<Cliente> clientes;

        //CONSTRUTOR PARA A LISTA
        public ManutencaoCliente(List<Cliente> clientes)
        {
            {
                this.clientes = clientes;
            }
        }

        public void Cadastra()
        {
            Console.Clear();
            ExibirLogo();
            Console.WriteLine("\nDigite o nome do Cliente: ");
            string nomeCliente = Console.ReadLine();
            Console.WriteLine("\nDigite o CPF: ");
            string cpfCliente = Console.ReadLine();
            Cliente cliente = new Cliente(nomeCliente, cpfCliente);
            clientes.Add(cliente);
            Console.WriteLine($"O Cliente: {nomeCliente} juntamente com seu CPF,  foi incluido com sucesso!");
            Console.WriteLine("Aperte qualquer tecla para voltar!");
            Console.ReadKey();
        }

        public void Lista()
        {
            Console.Clear();
            ExibirLogo();
            Console.WriteLine("\nClientes cadastrados:\n");
            clientes.ForEach(l => Console.WriteLine(l.ObterDescricao()));
            Console.WriteLine("\nAperte qualquer tecla para voltar!");
            Console.ReadKey();
        }

    }
}
