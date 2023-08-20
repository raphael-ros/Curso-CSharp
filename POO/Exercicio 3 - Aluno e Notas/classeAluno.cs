public class Aluno
{
    public string Nome;
    public double Nota1, Nota2, Nota3; 
    public double CalcularNota()
    {
        double media = Nota1 + Nota2 + Nota3;
        return media;
    }
    public string VerificarNota()
    {
        if(CalcularNota() < 60){
            return "REPROVADO";
        } 
        else{
            return "APROVADO";
        }
    }
    public double CalcularPontosFaltantes()
    {
        double pontosFaltantes = 0.0;
        pontosFaltantes = 60 - CalcularNota();
        return pontosFaltantes;
    }
}
