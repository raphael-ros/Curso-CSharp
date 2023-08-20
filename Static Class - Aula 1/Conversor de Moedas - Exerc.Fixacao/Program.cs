using System;
using System.Globalization;
using static System.Console;
using System.Globalization;

Clear();
WriteLine("[1] - Vender Dolares;\n[2] - Comprar Dólares.");
Write("Escolha qual função deseja aplicar: ");
int resp = int.Parse(ReadLine());
Clear();

switch (resp)
{
    case 1:
        Write("Escreva a cotação do dolar: R$");
        double cotacao = double.Parse(ReadLine(), CultureInfo.InvariantCulture);

        Write("Quantos dólares você vai vender? $");
        double qntDolares = double.Parse(ReadLine(), CultureInfo.InvariantCulture);

        double valorFinal = ConversorDeMoeda.DolarParaReal(cotacao, qntDolares);
        Write("Valor a ser recebido em reais: R$" + valorFinal.ToString("F2", CultureInfo.InvariantCulture));
        break;
    
    case 2:
        Write("Escreva a cotação do dolar: R$");
        cotacao = double.Parse(ReadLine(), CultureInfo.InvariantCulture);

        Write("Quantos dólares você vai comprar? ");
        qntDolares = double.Parse(ReadLine(), CultureInfo.InvariantCulture);

        valorFinal = ConversorDeMoeda.RealParaDolar(cotacao, qntDolares);
        Write("Valor a ser gasto em reais: R$" + valorFinal.ToString("F2", CultureInfo.InvariantCulture));
        break;
    default:
        WriteLine("Insira um número válido.");
        break;
}



