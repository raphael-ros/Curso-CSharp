public class Retangulo {
    public double Largura;
    public double Altura;

    public double Area(){
        double area = Largura * Altura;
        return area;
    }

    public double Perimetro(){
        double peri = 2*(Altura + Largura);
        return peri;
    }

    public double Diagonal(){
        double diag = Math.Sqrt((Altura*Altura + Largura*Largura));
        return diag;
    }
}