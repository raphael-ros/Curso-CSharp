using System;
using System.Globalization;
using static System.Console;
using System.Globalization;
using System.Net;

Clear();
int resp = 0;
while (resp <= 0 || resp >= 3)
    {
        WriteLine("[1] - Vender Dolares;\n[2] - Comprar Dólares.");
        Write("Escolha qual função deseja aplicar: ");
        resp = int.Parse(ReadLine());
        Clear();
        if (resp <= 0 || resp >= 3)
        {
            WriteLine("Insira um número válido.");
        }
    }
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
}



