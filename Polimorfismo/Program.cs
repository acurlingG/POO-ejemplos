using System;

public abstract class Figura
{
    public abstract double CalcularArea();
}

public class Rectangulo : Figura
{
    public double Ancho { get; set; }
    public double Alto { get; set; }

    public Rectangulo(double ancho, double alto)
    {
        Ancho = ancho;
        Alto = alto;
    }

    public override double CalcularArea()
    {
        return Ancho * Alto;
    }
}

public class Circulo : Figura
{
    public double Radio { get; set; }

    public Circulo(double radio)
    {
        Radio = radio;
    }

    public override double CalcularArea()
    {
        return Math.PI * Radio * Radio;
    }
}

public class Program
{
    public static void Main()
    {
        Figura[] figuras =
        {
            new Rectangulo(5, 3),
            new Circulo(2)
        };

        foreach (Figura figura in figuras)
        {
            Console.WriteLine(
                $"Área de {figura.GetType().Name}: {figura.CalcularArea():F2}");
        }
    }
}