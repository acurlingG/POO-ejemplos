using System;

public class Personaje
{
    public string Nombre { get; set; }
    public int Vida { get; set; }

    public Personaje(string nombre, int vida)
    {
        Nombre = nombre;
        Vida = vida;
    }

    public virtual void Atacar()
    {
        Console.WriteLine($"{Nombre} realiza un ataque.");
    }
}

public class Heroe : Personaje
{
    public string Poder { get; set; }

    public Heroe(string nombre, int vida, string poder)
        : base(nombre, vida)
    {
        Poder = poder;
    }

    public override void Atacar()
    {
        Console.WriteLine($"{Nombre} ataca usando su poder: {Poder}.");
    }
}

public class Villano : Personaje
{
    public string PlanMalvado { get; set; }

    public Villano(string nombre, int vida, string planMalvado)
        : base(nombre, vida)
    {
        PlanMalvado = planMalvado;
    }

    public override void Atacar()
    {
        Console.WriteLine($"{Nombre} ataca y ejecuta su plan: {PlanMalvado}.");
    }
}

public class Program
{
    public static void Main()
    {
        Personaje heroe = new Heroe("Luna", 100, "Rayo de luz");
        Personaje villano = new Villano("Sombra", 120, "Apagar el sol");

        heroe.Atacar();
        villano.Atacar();
    }
}