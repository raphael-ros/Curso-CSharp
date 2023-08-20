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