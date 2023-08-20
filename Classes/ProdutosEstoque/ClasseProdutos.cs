using System;
using static System.Console;

public class Produto
{
    public string Nome;
    public double Preco;
    public int Qnt;

    public double ValorTotalEmEstoque()
    {
        double valorTotal = Preco * Qnt;
        return valorTotal;
    }

    public void AdicionarProdutos(int quantity)
    {
        Qnt += quantity;
    }
    public void RemoverProdutos(int quantity)
    {
        Qnt -= quantity;
    }

    public void ShowInfos()
    {
        WriteLine($"Produto: {Nome}; Valor: R${Preco}; Quantidade Estoque: {Qnt}; Valor Total: R${ValorTotalEmEstoque()}");
    }

    public void ShowInfosAtual()
    {
        WriteLine("=-=-=-=-= Dados Atualizados =-=-=-=-=");
        WriteLine($"Produto: {Nome}; Valor: R${Preco}; Quantidade Estoque: {Qnt}; Valor Total: R${ValorTotalEmEstoque()}");
    }
}