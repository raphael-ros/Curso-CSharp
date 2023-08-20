using static System.Console;
using System.Globalization;

Funcionario a, b;
a = new Funcionario();
b = new Funcionario();

Clear();
Write("Escreva o nome do 1º funcionario: ");
a.Nome = ReadLine();
Write("Qual seu salário: R$");
a.Salario = double.Parse(ReadLine(), CultureInfo.InvariantCulture);

Clear();
Write("Escreva o nome do 2º funcionario: ");
b.Nome = ReadLine();
Write("Qual seu salário: R$");
b.Salario = double.Parse(ReadLine(), CultureInfo.InvariantCulture);

double media = 0;

media = (a.Salario + b.Salario) / 2;

Clear();
WriteLine($"{a.Nome} ganha: R${a.Salario.ToString("F2", CultureInfo.InvariantCulture)}.");
WriteLine($"{b.Nome} ganha: R${b.Salario.ToString("F2", CultureInfo.InvariantCulture)}.");
Write($"A média do salário de {a.Nome} e {b.Nome} é: R${media.ToString("F2", CultureInfo.InvariantCulture)}");