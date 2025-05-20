Console.WriteLine("Programa para calcular Volumen de un Cilindro");
Console.WriteLine("Ingrese el radio y la altura del cilindro");
double radio = Convert.ToDouble(Console.ReadLine());
double altura = Convert.ToDouble(Console.ReadLine());
Volumen cilindro1 = new Volumen(radio, altura);
cilindro1.MostrarInfo();
class Volumen
{
    private double Altura;
    private double Radio;
    
    public Volumen(double altura, double radio)
    {
        Altura = altura;
        Radio = radio;
    }
    public double CalcularVolumen()
    {
        return Math.PI * Math.Pow(Radio, 2)* Altura;
    }
    public void MostrarInfo()
    {
        Console.WriteLine($"Altura: {Altura}");
        Console.WriteLine($"Radio: {Radio}");
        Console.WriteLine($"Volumen: {(Math.PI * Math.Pow(Radio, 2)* Altura)}");
    }
}