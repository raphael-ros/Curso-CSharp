using static System.Console;
using System.Globalization;

Clear();

Funcionario func1 = new Funcionario();

Write("Nome do funcionario: ");
func1.Nome = ReadLine();

Write("Salário Bruto: R$");
func1.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Write("Imposto: R$");
func1.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Clear();

WriteLine($"Funcionario: {func1.Nome}; Salário Líquido: R${func1.SalarioLiquido()}");

Write("Digite a porcentagem para aumentar em cima do salário bruto: ");
double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
 func1.AumentarSalario(porcent);

WriteLine("porcent = " + porcent);
 WriteLine();
 WriteLine("-=-=-=-=-= Dados atualizados =-=-=-=-=-");
 WriteLine($"Funcionario: {func1.Nome}; Salário Bruto Att: R${func1.SalarioBruto}");