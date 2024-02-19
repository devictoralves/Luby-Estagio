using Maquina_de_Vendas.Base;
using System;
using System.Linq;
using System.Text;

public class MenuGerenciamento
{
    public Estoque Estoque { get; set; }

    public MenuGerenciamento(Estoque estoque)
    {
        Estoque = estoque;
    }

    public void AcessoRestrito()
    {
        Console.WriteLine("======= ÁREA RESTRITA A FUNCIONÁRIOS ========");
        Console.Write("Digite sua senha de acesso: ");
        int senha = int.Parse(Console.ReadLine());

        if (senha == 8708) { Back(); }
        else
        {
            Console.Clear();
            Console.Write("Senha Incorreta :( ");
        }
    }

    public void Back()
    {
        string opcaoSelecionada;

        do
        {
            Console.Clear();
            Console.WriteLine("=============================================");
            Console.WriteLine("|            MENU DE GERENCIAMENTO          |");
            Console.WriteLine("=============================================");
            Console.WriteLine("| 1 - Visualizar Vendas                     |");
            Console.WriteLine("| 2 - Adicionar Produtos                    |");
            Console.WriteLine("| 3 - Editar Produtos                       |");
            Console.WriteLine("| 4 - Voltar para o Menu Inicial            |");
            Console.WriteLine("=============================================");

            Console.Write("Selecione uma opção: ");
            opcaoSelecionada = Console.ReadLine();

            switch (opcaoSelecionada)
            {
                case "1":
                    Console.Clear();
                    VisualizarVendas();
                    break;
                case "2":
                    Console.Clear();
                    AdicionarProduto();
                    break;
                case "3":
                    Console.Clear();
                    EditarProdutos();
                    break;
                case "4":
                    Console.Clear();
                    Console.Write("Até a próxima! ");
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Opção Inválida! Tente novamente.");
                    break;
            }

        } while (opcaoSelecionada != "4");
    }

    public void VisualizarVendas()
    {
        Console.WriteLine("===============================================");
        Console.WriteLine("|           Relatório de Vendas               |");
        Console.WriteLine("===============================================");
        Console.WriteLine("| Produto            |  Vendas |   Total   R$ |");
        Console.WriteLine("===============================================");

        foreach (var produto in Estoque.ObterProdutos())
        {
            string nomeFormatado = produto.Nome.PadRight(18);
            string vendasFormatado = (produto.QtdInicial - produto.Qtd).ToString().PadLeft(7);
            string totalFormatado = ((produto.QtdInicial - produto.Qtd) * produto.Preco).ToString("C2").PadLeft(12);

            Console.WriteLine($"| {nomeFormatado} | {vendasFormatado} | {totalFormatado} |");
        }

        Console.WriteLine("===============================================");
        Console.WriteLine($"| Total de Vendas                     {Estoque.ObterProdutos().Sum(p => (p.QtdInicial - p.Qtd) * p.Preco).ToString("C2")} |");
        Console.WriteLine("===============================================");
        Console.Write("\nAperte qualquer tecla para voltar..");
        Console.ReadLine();
    }

    public void AdicionarProduto()
    {
        VisualizarProdutos();

        Console.Write("Digite o nome do novo produto (ou ESC para cancelar): ");
        string nome = LerComCancelamento();

        if (string.IsNullOrEmpty(nome))
        {
            Console.WriteLine("Adição de produto cancelada.");
            return;
        }

        Console.Write("Digite o preço do produto: ");
        double preco = double.Parse(Console.ReadLine());

        Console.Write("Digite a quantidade inicial do produto: ");
        int quantidade = int.Parse(Console.ReadLine());

        Console.Clear();

        Produto novoProduto = new Produto { Nome = nome, Preco = preco, Qtd = quantidade, QtdInicial = quantidade };
        Estoque.AdicionarProduto(novoProduto);
        Console.WriteLine("Produto adicionado com sucesso!");
    }

    public void EditarProdutos()
    {
        VisualizarProdutos();

        Console.Write("Digite o nome do produto para editar (ou ESC para cancelar): ");
        string nome = LerComCancelamento();

        if (string.IsNullOrEmpty(nome))
        {
            Console.Clear();
            Console.WriteLine("Edição de estoque cancelada.");
            return;
        }

        Produto produto = Estoque.ObterProdutoPorNome(nome);

        if (produto == null)
        {
            Console.Clear();
            Console.WriteLine("Produto não encontrado");
            return;
        }

        Console.Clear();
        Console.WriteLine("===============================================");
        Console.WriteLine($"| Produto: {ProdutoFormatado(produto.Nome),-34} |");
        Console.WriteLine($"| Preço atual: {produto.Preco,-30:C2} |");
        Console.WriteLine($"| Quantidade atual: {produto.Qtd,-25} |");
        Console.WriteLine("===============================================");

        Console.WriteLine("\nEscolha a ação:");
        Console.WriteLine("1. Editar Produto");
        Console.WriteLine("2. Excluir Produto");
        Console.Write("\nDigite o número da opção desejada: ");

        string opcao = Console.ReadLine();

        Console.Clear();
        Console.WriteLine("===============================================");
        Console.WriteLine($"| Produto: {ProdutoFormatado(produto.Nome),-34} |");
        Console.WriteLine($"| Preço atual: {produto.Preco,-30:C2} |");
        Console.WriteLine($"| Quantidade atual: {produto.Qtd,-25} |");
        Console.WriteLine("===============================================");

        switch (opcao)
        {
            case "1":
                Console.Write("Digite o novo nome (ou ENTER para manter o atual): ");
                string novoNome = Console.ReadLine();

                if (!string.IsNullOrEmpty(novoNome))
                {
                    produto.Nome = novoNome;
                }

                Console.Write("Digite a nova quantidade (ou ENTER para manter a atual): ");
                string novaQuantidadeInput = Console.ReadLine();
                int novaQuantidade;

                if (string.IsNullOrEmpty(novaQuantidadeInput))
                {
                    novaQuantidade = produto.Qtd;
                }
                else if (!int.TryParse(novaQuantidadeInput, out novaQuantidade))
                {
                    Console.WriteLine("Quantidade inválida. A edição foi cancelada.");
                    return;
                }

                Console.Write("Digite o novo preço (ou ENTER para manter o atual): ");
                string novoPrecoInput = Console.ReadLine();
                double novoPreco;

                if (string.IsNullOrEmpty(novoPrecoInput))
                {
                    novoPreco = produto.Preco;
                }
                else if (!double.TryParse(novoPrecoInput, out novoPreco))
                {
                    Console.WriteLine("Preço inválido. A edição foi cancelada.");
                    return;
                }

                produto.QtdInicial += (novaQuantidade - produto.Qtd);
                produto.Qtd = novaQuantidade;
                produto.Preco = novoPreco;

                Console.WriteLine("Produto editado com sucesso!");
                break;

            case "2":
                Estoque.RemoverProduto(produto);
                Console.WriteLine("Produto excluído com sucesso!");
                break;

            default:
                Console.WriteLine("Opção inválida");
                break;
        }

        Console.Clear();
        VisualizarProdutos();
    }

    public void VisualizarProdutos()
    {
        Console.WriteLine("===============================================");
        Console.WriteLine("|                ESTOQUE ATUAL                |");
        Console.WriteLine("===============================================");
        Console.WriteLine("|        Nome        |  Preço  |  Quantidade  |");
        Console.WriteLine("===============================================");

        foreach (var produto in Estoque.ObterProdutos())
        {
            Console.WriteLine($"| {ProdutoFormatado(produto.Nome),-18} | {produto.Preco,6:C2} | {produto.Qtd,12} |");
        }

        Console.WriteLine("===============================================\n");
    }

    public string ProdutoFormatado(string nome)
    {
        if (nome.Length > 18)
            nome = nome.Substring(0, 15) + "...";

        return nome;
    }

    public string LerComCancelamento()
    {
        StringBuilder input = new StringBuilder();
        ConsoleKeyInfo key;

        do
        {
            key = Console.ReadKey(true);

            if (key.Key == ConsoleKey.Backspace && input.Length > 0)
            {
                input.Remove(input.Length - 1, 1);
                Console.Write("\b \b");
            }
            else if (key.Key != ConsoleKey.Enter && key.Key != ConsoleKey.Escape)
            {
                input.Append(key.KeyChar);
                Console.Write(key.KeyChar);
            }
        } while (key.Key != ConsoleKey.Enter && key.Key != ConsoleKey.Escape);

        Console.WriteLine();

        if (key.Key == ConsoleKey.Escape)
        {
            return string.Empty; // Retorna string vazia para indicar cancelamento
        }

        return input.ToString();
    }
}
