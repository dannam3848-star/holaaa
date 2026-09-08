using System;
					
public class Program
{
	public static void Main()
	{
		string[] nombres = new string[3];
string[] ciudades = new string[3];
int[] edades = new int[3];
string[] colorFavorito = new string[3];
string[] dinero = new string[3];
string[] estatura = new string[3];
			Console.Write("PERSONAJE 1 ");

    Console.Write("Escribe tu nombre: ");
    nombres[0] = Console.ReadLine();
	
	Console.Write("Escribe tu edad: ");
    edades[0] = int.Parse(Console.ReadLine());
	
	Console.Write("Escribe tu ciudad: ");
    string ciudad = Console.ReadLine();
	ciudades[0] = ciudad;
	
	 Console.Write("¿cual es tu estatura? ");
     estatura[0] = Console.ReadLine();
	
	 Console.Write("¿cuanto dinero tienes contigo? ");
     dinero[0] = Console.ReadLine();
	
	 Console.Write("¿color favorito? ");
    colorFavorito[0] = Console.ReadLine();
	
	
	  //caracteristicas 

     int[] vida = { 5,8,2 };
     int[] puntos = { 23, 13, 3 };
     float[] velocidad = { 2.5f, 3.4f, 5.6f };
     bool[] tieneLlave = { true, false, true};
     bool[] estaEnLaPuerta = { true, false, true };
	
	Console.WriteLine("vida :" + vida[0]);
   Console.WriteLine("puntos :" + puntos[0]);
   Console.WriteLine("velocidad :" + velocidad[0]);
   Console.WriteLine("tieneLlave :" + tieneLlave[0]);
  Console.WriteLine("estaEnLaPuerta :" + estaEnLaPuerta[0]);
	
	
    Console.WriteLine($"Hola, {nombres[0]}");
	Console.WriteLine($"{nombres[0]} tiene {edades[0]}");
	Console.WriteLine($"{nombres[0]} vive en {ciudades[0]}");
	  
	//PERSONAJE
	
	Console.Write("PERSONAJE 2 ");
	
	 Console.Write("Escribe tu nombre: ");
    nombres[1] = Console.ReadLine();
	
	Console.Write("Escribe tu edad: ");
    edades[1] = int.Parse(Console.ReadLine());
	
	Console.Write("Escribe tu ciudad: ");
    ciudad = Console.ReadLine();
	ciudades[1] = ciudad;
	
	 Console.Write("¿cual es tu estatura? ");
     dinero[1] = Console.ReadLine();
	
	 Console.Write("¿cuanto dinero tienes contigo? ");
     dinero[1] = Console.ReadLine();
	
	 Console.Write("¿color favorito? ");
    colorFavorito[1] = Console.ReadLine();
	
	
	Console.WriteLine("vida :" + vida[1]);
   Console.WriteLine("puntos :" + puntos[1]);
   Console.WriteLine("velocidad :" + velocidad[1]);
   Console.WriteLine("tieneLlave :" + tieneLlave[1]);
  Console.WriteLine("estaEnLaPuerta :" + estaEnLaPuerta[1]);
	
    Console.WriteLine($"Hola, {nombres[1]}");
	Console.WriteLine($"{nombres[1]} tiene {edades[1]}");
	Console.WriteLine($"{nombres[1]} vive en {ciudades[1]}");
	
	//PERSONAJE 2
	
	Console.Write("PERSONAJE 3 ");

	 Console.Write("Escribe tu nombre: ");
    nombres[2] = Console.ReadLine();
	
	Console.Write("Escribe tu edad: ");
    edades[2] = int.Parse(Console.ReadLine());
	
	Console.Write("Escribe tu ciudad: ");
    ciudad = Console.ReadLine();
	ciudades[2] = ciudad;
	
	 Console.Write("¿cual es tu estatura? ");
     dinero[2] = Console.ReadLine();
	
	 Console.Write("¿cuanto dinero tienes contigo? ");
     dinero[2] = Console.ReadLine();
	
	 Console.Write("¿color favorito? ");
    colorFavorito[2] = Console.ReadLine();

 
	Console.WriteLine("vida :" + vida[2]);
   Console.WriteLine("puntos :" + puntos[2]);
   Console.WriteLine("velocidad :" + velocidad[2]);
   Console.WriteLine("tieneLlave :" + tieneLlave[2]);
  Console.WriteLine("estaEnLaPuerta :" + estaEnLaPuerta[2]);
	
    Console.WriteLine($"Hola, {nombres[2]}");
	Console.WriteLine($"{nombres[2]} tiene {edades[2]}");
	Console.WriteLine($"{nombres[2]} vive en {ciudades[2]}");
		
    }
}
