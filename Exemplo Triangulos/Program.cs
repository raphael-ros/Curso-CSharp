using static System.Console;
using System.Globalization;
// See https://aka.ms/new-console-template for more information

Triangulo x, y;
x = new Triangulo();
y = new Triangulo();

Clear();
WriteLine("Entre com as medidas do triangulo X:");
x.LadoA = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
x.LadoB = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
x.LadoC = double.Parse(ReadLine(), CultureInfo.InvariantCulture);

WriteLine("Entre com as medidas do triangulo Y:");
y.LadoA = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
y.LadoB = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
y.LadoC = double.Parse(ReadLine(), CultureInfo.InvariantCulture);

double areaX = x.Area();
double areaY = y.Area();

WriteLine("Área de X: " + areaX.ToString("F4", CultureInfo.InvariantCulture));
WriteLine("Área de Y: " + areaY.ToString("F4", CultureInfo.InvariantCulture));

if(areaX > areaY)
    WriteLine("Maior área é de X");

else if(areaX < areaY)
    WriteLine("Maior área é de Y");

else
    WriteLine("Eles tem a mesma área");