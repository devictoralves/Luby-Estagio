bool continuarOperacao = true;
VendingMachine maquinaVendas = new VendingMachine();

while (continuarOperacao)
{
    Console.Clear();
    Console.WriteLine("=============================================");
    Console.WriteLine("|           LUBY - MÁQUINA DE VENDAS        |");
    Console.WriteLine("=============================================");
    Console.WriteLine("| 1 - Comprar Produtos                      |");
    Console.WriteLine("| 2 - Visualizar Produtos                   |");
    Console.WriteLine("| 3 - Acesso Restrito                       |");
    Console.WriteLine("| 4 - Encerrar                              |");
    Console.WriteLine("=============================================");

    Console.Write("\n Selecione uma opção: ");
    string opcaoSelecionada = Console.ReadLine();
    Console.Clear();

    MenuGerenciamento menuGerenciamento = new MenuGerenciamento(maquinaVendas.Estoque);

    if (opcaoSelecionada == "1") { maquinaVendas.ComprarProduto(); }
    else if (opcaoSelecionada == "2") { menuGerenciamento.VisualizarProdutos(); }
    else if (opcaoSelecionada == "3") { menuGerenciamento.AcessoRestrito(); }
    else if (opcaoSelecionada == "4") { Console.WriteLine("Até a próxima!"); Environment.Exit(0); }
    else { Console.WriteLine("Ops, algo deu errado. Por favor, tente novamente!"); }

    Console.Write("Pressione qualquer tecla para retornar ao MENU INICIAL..");
    Console.ReadKey();
}
