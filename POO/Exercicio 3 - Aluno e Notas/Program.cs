using static System.Console;
using System.Globalization;

Clear();

Aluno aluno1 = new Aluno();

Write("Nome do aluno: ");
aluno1.Nome = ReadLine();

Write("Nota 1: ");
aluno1.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Write("Nota 2: ");
aluno1.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Write("Nota 3: ");
aluno1.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Clear();
WriteLine($"Nome do aluno: {aluno1.Nome}");
WriteLine($"Nota final: {aluno1.CalcularNota()}");
WriteLine($"Situação: {aluno1.VerificarNota()}");

if(aluno1.VerificarNota() == "REPROVADO"){
    Write($"Faltaram: {aluno1.CalcularPontosFaltantes()} pontos");
}