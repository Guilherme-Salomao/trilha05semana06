class Menu
{
    public void ExibirLogo()
    {
        Console.WriteLine(@"
░██████╗███████╗███╗░░░███╗░█████╗░███╗░░██╗░█████╗░  ░█████╗░███████╗
██╔════╝██╔════╝████╗░████║██╔══██╗████╗░██║██╔══██╗  ██╔══██╗██╔════╝
╚█████╗░█████╗░░██╔████╔██║███████║██╔██╗██║███████║  ██║░░██║██████╗░
░╚═══██╗██╔══╝░░██║╚██╔╝██║██╔══██║██║╚████║██╔══██║  ██║░░██║╚════██╗
██████╔╝███████╗██║░╚═╝░██║██║░░██║██║░╚███║██║░░██║  ╚█████╔╝██████╔╝
╚═════╝░╚══════╝╚═╝░░░░░╚═╝╚═╝░░╚═╝╚═╝░░╚══╝╚═╝░░╚═╝  ░╚════╝░╚═════╝░");
    }

    //Criando a lista de produtos
    private List<Produto> produtos = new List<Produto>();

    public void ExibirMenu()
    {
        Console.WriteLine("\nDigite 1 para registrar um Produto");
        Console.WriteLine("Digite 2 para listar os Produtos");
        Console.WriteLine("Digite -1 para sair");
        Console.Write("\nDigite a sua opção: ");
        string opcaoEscolhida = Console.ReadLine()!;
        int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

        switch (opcaoEscolhidaNumerica)
        {
            case 1:
                CadastraProduto();
                break;
            case 2:
                ListaProduto();
                break;
            case -1:
                Console.WriteLine("Tchau tchau :)");
                break;
            default:
                Console.WriteLine("Opção inválida");
                break;
        }
    }
    public void CadastraProduto()
    {
        Console.Clear();
        ExibirLogo();
        Console.WriteLine("\nDigite um produto: ");
        string nomeProduto = Console.ReadLine()!;
        Produto produto = new Produto(nomeProduto);
        produtos.Add(produto);
        Console.WriteLine($"O produto {nomeProduto} foi incluido com sucesso!");
        Console.WriteLine("Aperte qualquer tecla para voltar!");
        Console.ReadKey();
        Console.Clear();
        ExibirLogo();
        ExibirMenu();
    }
    public void ListaProduto()
    {
        Console.Clear();
        ExibirLogo();
        Console.WriteLine("\nProdutos cadastrados:\n");
        produtos.ForEach(p => Console.WriteLine(p.Nome));
        Console.WriteLine("\nAperte qualquer tecla para voltar!");
        Console.ReadKey();
        Console.Clear();
        ExibirLogo();
        ExibirMenu();
    }
}