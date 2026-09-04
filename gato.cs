using System;
					
class Program
{
 static void Main()
	{
	 
	       //caracteristicas 
	     string[] nombres = { "Amanda", "idia", "ana","not","juan"};
	     int[] vida = { 5,8,2,1,3 };
	     int[] puntos = { 23, 13, 34, 15, 6 };
	     float[] velocidad = { 2.5f, 3.4f, 5.6f, 4.1f, 5.1f };
	     bool[] tieneLlave = { true, false, true, true, false };
	     bool[] estaEnLaPuerta = { true, false, false, true, false };
	   
	    int jugadorActual = 1;
	 
	   Console.WriteLine("nombres :" + nombres[ jugadorActual]);
	   Console.WriteLine("vida :" + vida[ jugadorActual]);
	   Console.WriteLine("puntos :" + puntos[ jugadorActual]);
	   Console.WriteLine("velocidad :" + velocidad[ jugadorActual]);
	   Console.WriteLine("tieneLlave :" + tieneLlave[ jugadorActual]);
	  Console.WriteLine("estaEnLaPuerta :" + estaEnLaPuerta[ jugadorActual]);
	 
	 
	 
	 
	     }
}
