using static System.Console;
using System.Globalization;

Clear();

Retangulo r1 = new Retangulo();

WriteLine("Entre com a Largura e Altura do Retângulo:");
Write("Altura(m²): ");
r1.Altura = double.Parse(ReadLine());
Write("\nLargura(m²): ");
r1.Largura = double.Parse(ReadLine());

WriteLine("A Area, Perimetro e DIagonal do Retangulo passado são:");
WriteLine("Area: " + r1.Area().ToString("F2", CultureInfo.InvariantCulture) + "m²");
WriteLine("Perimetro: " + r1.Perimetro().ToString("F2", CultureInfo.InvariantCulture) + "m²");
WriteLine("Diagonal: " + r1.Diagonal().ToString("F2", CultureInfo.InvariantCulture) + "m²");



