using static System.Console;
using System.Globalization;

Produto a = new Produto();
Produto b = new Produto();

Clear();
WriteLine("Qual produto deseja cadastrar?");
WriteLine("[1] - TV;\n[2] - Computador");
int resp = int.Parse(ReadLine());
Produto p = new Produto();;
if(resp == 1){
    p = a;
    a.Nome = "TV";
}
    
else {
    p = b;
    b.Nome = "Computador";
}


Clear();
Write("Preço: ");
p.Preco = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
Write("Quantidade em estoque: ");
a.Qnt = int.Parse(ReadLine());
Clear();

p.ShowInfos();
WriteLine();

Write("Quantos produtos deseja ADICIONAR ao estoque: ");
int add = int.Parse(ReadLine());
Clear();
p.AdicionarProdutos(add);
p.ShowInfosAtual();

Write("Quantos produtos deseja REMOVER ao estoque: ");
int remove = int.Parse(ReadLine());
p.RemoverProdutos(remove);
Clear();

p.ShowInfosAtual();

