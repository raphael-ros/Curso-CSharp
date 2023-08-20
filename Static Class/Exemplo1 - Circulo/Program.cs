using static System.Console;
using System;
using System.Globalization;
using System.Net.NetworkInformation;

Clear();

Write("Entre com o valor do raio: ");
double raio = double.Parse(ReadLine(), CultureInfo.InvariantCulture);

double circ = Calculadora.Circunferencia(raio);
double vol = Calculadora.Volume(raio);

WriteLine("Circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture) + "m².");
WriteLine("Volume: " + vol.ToString("F2", CultureInfo.InvariantCulture) + "m³.");
WriteLine("Valor de pi: " + Calculadora.Pi + ".");
