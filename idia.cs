using System;
					
class Program
{
 static void Main()
	{
	     //idia
	
	    string nombre = "idia";
        int vidas = 5;
	    int puntos = 4;
        float velocidad = 5.5f; 
	
	 
	     //variable booleanas
	 
	  bool tieneLlave = true;
	  bool estaEnLaPuerta = true;
	  bool entrar = tieneLlave && estaEnLaPuerta;
	 
	     //mostrar resultados
	  
	 Console.WriteLine("Nombre: " + nombre);
	 Console.WriteLine("vidas: " + vidas);
	 Console.WriteLine("Puntos: " + puntos);
	 Console.WriteLine("velocidad: " + velocidad);
	 Console.WriteLine("tieneLlave: " + tieneLlave);
	 Console.WriteLine("estaEnLaPuerta: " + estaEnLaPuerta);
	 Console.WriteLine("entrar: " + entrar);
	 
	    
	  vidas = vidas - 3;
	  puntos = puntos - 2;
	  velocidad = velocidad + 2.0f;
	  

  }
}	 


	 

	 
