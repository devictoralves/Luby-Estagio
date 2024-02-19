using Maquina_de_Vendas.Base;
using System;
using System.Collections.Generic;
using System.Linq;

public class Estoque
{
    private List<Produto> Produtos { get; set; }

    public Estoque()
    {
        Produtos = new List<Produto>
        {
            new Produto { Nome = "H2O", Preco = 2.50, QtdInicial = 75, Qtd = 75},
            new Produto { Nome = "Pepsi", Preco = 7.00, QtdInicial = 60, Qtd = 60},
            new Produto { Nome = "Sprite", Preco = 6.50, QtdInicial = 70, Qtd = 70},
            new Produto { Nome = "Fanta", Preco = 3.00, QtdInicial = 65, Qtd = 65},
            new Produto { Nome = "CocaCola", Preco = 8.00, QtdInicial = 85, Qtd = 85},
            new Produto { Nome = "Pitu", Preco = 7.00, QtdInicial = 100, Qtd = 100}
        };
    }

    public void AdicionarProduto(Produto produto)
    {
        Produtos.Add(produto);
    }

    public void RemoverProduto(Produto produto)
    {
        Produtos.Remove(produto);
    }

    public IEnumerable<Produto> ObterProdutos()
    {
        return Produtos;
    }

    public Produto ObterProdutoPorNome(string nome)
    {
        return Produtos.FirstOrDefault(p => p.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
    }
}
