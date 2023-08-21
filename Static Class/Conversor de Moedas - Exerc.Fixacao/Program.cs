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
        double valorFinal = ConversorDeMoeda.DolarParaReal(showMsg.Cotacao(), showMsg.QntDolares());
        Write("Valor a ser recebido em reais: R$" + valorFinal.ToString("F2", CultureInfo.InvariantCulture));
        break;
    
    case 2:
        valorFinal = ConversorDeMoeda.RealParaDolar(showMsg.Cotacao(), showMsg.QntDolares());
        Write("Valor a ser gasto em reais: R$" + valorFinal.ToString("F2", CultureInfo.InvariantCulture));
        break;
    default:
        WriteLine("Insira um número válido.");
        break;
}



