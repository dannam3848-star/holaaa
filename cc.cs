using System;
					
public class Program
{
	public static void Main()
	{
		static int Doble(int numero)
{
    return numero * 2; // termina la función y entrega el resultado
}

int resultado = Doble(4); // resultado ahora vale 8
Console.WriteLine(resultado);
		string[] textos = new string[9];
int[] saltos    = new int[9];

textos[0] = "Bogotá amanece gris. Miras el celular: 7:18 a.m.";
saltos[0] = 0;

textos[1] = "La clase empieza a las 8:00. Sales corriendo a la calle.";
saltos[1] = 0;

textos[2] = "Llegas a la esquina. 1) Tomar el camino conocido. 2) Tomar un atajo.";
saltos[2] = 5; // si el usuario responde "2", salta a la posición 5

textos[3] = "Caminas por la ruta de siempre, pasando la panadería.";
saltos[3] = 0;

textos[4] = "Llegas a clase justo a tiempo. FINAL: LLEGASTE.";
saltos[4] = 1; // esta línea es un final: el programa debe terminar aquí

textos[5] = "Entras por el atajo. Al fondo hay una construcción bloqueando el paso.";
saltos[5] = 0;

textos[6] = "1) Rodear por el andén. 2) Cruzar la calle rápidamente.";
saltos[6] = 8; // si el usuario responde "2", salta a la posición 8

textos[7] = "Rodeas con cuidado y llegas a clase apenas a tiempo. FINAL: LLEGASTE.";
saltos[7] = 1; // otro final

textos[8] = "Cruzas justo cuando pasa una moto. FINAL: NO LLEGASTE.";
saltos[8] = 1; // otro final más
		static int ManejarLinea(string texto, int numeroSalto)
{
    Console.WriteLine(texto);

    if (numeroSalto == 1)
    {
        return 1; // esta línea es un final: hay que terminar el cuento
    }

    if (numeroSalto == 0)
    {
        return 0; // esta línea no era una decisión, no hay nada más que hacer
    }

    string entrada = Console.ReadLine();

    if (entrada == "1")
    {
        return 0; // opción 1: seguir la secuencia normal
    }

    if (entrada == "2")
    {
        return numeroSalto; // opción 2: saltar a la línea indicada
    }

    return 0; // valor por defecto: si el usuario escribió algo inválido, seguimos normal
}
		static void Main()
{
    string[] textos = new string[9];
    int[] saltos    = new int[9];

    // ... (aquí van las 9 líneas que llenamos arriba) ...
        for (int i = 0; i < textos.Length; i++){
			int resultado = ManejarLinea(textos[i], saltos[i]);

			if (resultado == 1)
			{
				break;
			}

			else if (resultado != 0)
			{
				i = resultado - 1; // nos ubicamos justo antes de la línea destino...
			}
			// ...porque el for, al terminar la vuelta, le suma 1 a "i" automáticamente
		}
}
	}
}
