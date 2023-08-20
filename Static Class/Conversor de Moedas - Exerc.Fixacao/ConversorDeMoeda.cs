using System;
using System.Globalization;
using static System.Console;
using System.Globalization;

public class ConversorDeMoeda {
    public static double IOF = 0.06;

    public static double DolarParaReal(double cotacao, double quantia)
    {
        return (quantia - (IOF * quantia)) * cotacao;
    }

    public static double RealParaDolar(double cotacao, double quantia)
    {
        return (quantia + (IOF * quantia)) * cotacao;
    }
}

public class showMsg {
    double cotacaoDia = 0.0;
    double qntDolares = 0.0;

    public static double Cotacao()
    {
        Write("Escreva a cotação do dolar: R$");
        double cotacaoDia = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
        return cotacaoDia;
    }

    public static double QntDolares()
    {
        Write("Quantos dólares você possui? $");
        double qntDolares = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
        return qntDolares;
    }
}