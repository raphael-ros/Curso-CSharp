using static System.Console;

Pessoa a, b;
a = new Pessoa();
b = new Pessoa();

Clear();
Write("Insira o nome da 1ª pessoa: ");
a.Nome = ReadLine();
Write("Insira a idade da 1ª pessoa: ");
a.Idade = int.Parse(ReadLine());
Clear();

Write("Insira o nome da 2ª pessoa: ");
b.Nome = ReadLine();
Write("Insira a idade da 2ª pessoa: ");
b.Idade = int.Parse(ReadLine());
Clear();

if(a.Idade < b.Idade)
    Write($"{b.Nome} é mais velho que {a.Nome} com {b.Idade} anos.");
else if(a.Idade == b.Idade)
    Write($"{a.Nome} e {b.Nome} tem a mesma idade({a.Idade} anos).");
else
    Write($"{a.Nome} é mais velho que {b.Nome} com {a.Idade} anos.");