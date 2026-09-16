using System;

public class Program
{
    delegate void Evento();
	
    static void AtaquePorUnPerro()
    {
        Console.WriteLine("Encontraste un perro rabioso.");
    }

    static void EncontrarMoneda()
    {
        Console.WriteLine("Encontraste una moneda de oro brillante.");
    }

    static void EncontrarTrampa()
    {
        Console.WriteLine("¡Cuidado! Pisaste una trampa y pierdes 10 de vida.");
    }

    static void EncontrarPocion()
    {
        Console.WriteLine("Encontraste una poción de curación.");
    }

    static void EjecutarEventoAleatorio(Evento[] eventos)
    {
        Random rnd = new Random();
        int indice = rnd.Next(eventos.Length);
        eventos[indice]();
    }

    public static void Main()
    {
        Evento[] posibles = {AtaquePorUnPerro, EncontrarMoneda, EncontrarTrampa, EncontrarPocion, AtaquePorUnPerro };

        Console.WriteLine("Entras al bosque...");
        EjecutarEventoAleatorio(posibles);
    }
}
