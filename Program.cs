System.Console.WriteLine("Insira 3 números:");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

int resultado = Maior(a,b,c);
int resultado2 = Maior(10,12,15);
int soma = Soma(a,b,c);

System.Console.WriteLine("Maior = " + resultado);
System.Console.WriteLine("Maior = " + resultado2);

System.Console.WriteLine("Soma = " + soma);

static int Soma(int n1, int n2, int n3){
    int soma1 = 0;
    soma1 = n1 + n2 + n3;
    return soma1;
}

static int Maior(int x, int y, int z){
    int maior = int.MinValue;

    if (x > y && x > z)
        maior = x;
    else if(y > z)
        maior = y;
    else
        maior = z;
        
    return maior;
}
