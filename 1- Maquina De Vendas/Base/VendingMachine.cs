using Maquina_de_Vendas.Base;
using System.Text;

public class VendingMachine
{
    public Estoque Estoque { get; set; }
    public double Vendas { get; set; }

    public VendingMachine()
    {
        Estoque = new Estoque();
    }

    public void Iniciar()
    {
        MenuGerenciamento menuGerenciamento = new MenuGerenciamento(Estoque);
        menuGerenciamento.AcessoRestrito();
    }

    public void ComprarProduto()
    {
        VisualizarProdutos();

        Console.Write("Digite o nome do produto (ou ESC para cancelar): ");
        string nome = LerComCancelamento();

        if (string.IsNullOrEmpty(nome))
        {
            Console.WriteLine("Compra de produto cancelada.");
            return;
        }

        string[] partesNome = nome.Split('-');
        string nome_produto = "";

        if (partesNome.Length > 1)
        {
            string primeiraPalavra = partesNome[0];
            string segundaPalavra = partesNome[1];

            char primeiraLetraNome1 = char.ToUpper(primeiraPalavra[0]);
            char primeiraLetraNome2 = char.ToUpper(segundaPalavra[0]);

            nome_produto = $"{primeiraLetraNome1}{primeiraPalavra.Substring(1)}-{primeiraLetraNome2}{segundaPalavra.Substring(1)}";
        }
        else
        {
            char primeiraLetra = char.ToUpper(nome[0]);
            nome_produto = $"{primeiraLetra}{nome.Substring(1)}";
        }

        Produto produto = Estoque.ObterProdutoPorNome(nome_produto);

        if (produto == null)
        {
            Console.WriteLine("Produto não encontrado");
            return;
        }

        if (produto.Qtd == 0)
        {
            Console.WriteLine("Não temos mais desse produto em estoque");
            return;
        }

        Console.Write($"Digite a quantidade de {produto.Nome} que você deseja comprar: ");
        int quantidadeDesejada = int.Parse(Console.ReadLine());

        if (quantidadeDesejada > produto.Qtd)
        {
            Console.WriteLine("Quantidade desejada maior do que a disponível em estoque.");
            return;
        }

        double valorTotal = produto.Preco * quantidadeDesejada;

        Console.Write($"Digite quanto você vai pagar por {quantidadeDesejada} unidades: ");
        double valorPago = double.Parse(Console.ReadLine());

        while (valorPago < valorTotal)
        {
            Console.WriteLine($"Valor insuficiente...\nAdicione mais R${valorTotal - valorPago:F2} Ou digite 0 para cancelar");

            double pago = double.Parse(Console.ReadLine());

            while (pago < 0)
            {
                Console.WriteLine("Valor inválido, tente novamente");
                pago = double.Parse(Console.ReadLine());
            }

            if (pago == 0)
            {
                Console.WriteLine("Compra cancelada");
                return;
            }

            valorPago += pago;
        }

        double troco = valorPago - valorTotal;

        Console.WriteLine($"Troco: R$ {troco:F2}");

        produto.Qtd -= quantidadeDesejada;

        Vendas += valorTotal;

        Console.WriteLine($"{quantidadeDesejada} unidades do produto {produto.Nome} compradas com sucesso");
    }

    private void VisualizarProdutos()
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

    private string ProdutoFormatado(string nome)
    {
        if (nome.Length > 18)
            nome = nome.Substring(0, 15) + "...";

        return nome;
    }

    private string LerComCancelamento()
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
            return string.Empty;
        }

        return input.ToString();
    }
}
