using System;
public class Jugador
{
    public string nombre;
    public string rol;
    public int energia;
    public int hambre;
    public int paga;
    public int tiempo;
	
	  int[] guardiaDePatoPresidencial = { 90, 50, 100, 5 };
	  int[] traductorDePeces = { 30, 20, 20, 3 };
	  int[] entrenadorDePalomas = { 60, 30, 10, 5 };
	  int[] repartidorDePaquetes = { 80, 80, 50, 2 };
	  int[] cuidadoDePlantas = { 50, 40, 30, 8 };	
	  
	  public Jugador (string nombreElegido, string  rolTemp){
			  nombre = nombreElegido;
			  rol = rolTemp;
		  	asignarCaracteristicas ();
			 
		}
	
     private void asignarCaracteristicas()
	 {
		
	   if (rol == "guardia de pato presidencial"){
	   		energia =  guardiaDePatoPresidencial[0]; 
		    hambre =  guardiaDePatoPresidencial[1]; 
			paga =  guardiaDePatoPresidencial[2]; 
	        tiempo =  guardiaDePatoPresidencial[3]; 
	      }
	   else if (rol == "traductor de peces"){
	   		energia =  traductorDePeces[0]; 
		    hambre =  traductorDePeces[1]; 
			paga =  traductorDePeces[2]; 
	        tiempo =  traductorDePeces[3]; 
	      }
		 else if (rol == "entrenador de palomas"){
	   		energia =  entrenadorDePalomas [0]; 
		    hambre =  entrenadorDePalomas [1]; 
			paga =  entrenadorDePalomas [2]; 
	        tiempo = entrenadorDePalomas [3]; 
	      }
		  else if (rol == "Repartidor de paquetes"){
	   		energia =   repartidorDePaquetes[0]; 
		    hambre =   repartidorDePaquetes[1]; 
			paga =   repartidorDePaquetes[2]; 
	        tiempo =  repartidorDePaquetes [3]; 
	      }
		  else 
		  { 
	   		energia =   repartidorDePaquetes[0]; 
		    hambre =   repartidorDePaquetes[1]; 
			paga =   repartidorDePaquetes[2]; 
	        tiempo =  repartidorDePaquetes [3]; 
	      }
	 }
	public void mostrarPersoanje()
	{
		Console.Write($"Rol:{rol}  ");
		Console.Write($"nombre:{nombre}  ");
		Console.Write($"Energia:{energia}  ");
		Console.Write($"Hambre:{hambre}  ");
		Console.Write($"Paga: {paga}  ");
		Console.Write($"Tiempo: {tiempo}  ");
	}
	
}

public class Program
{
	public static string trabajos ()
		{	
			string herramienta;
			Console.Write("Escoge tu herramienta:  ");
       		herramienta = Console.ReadLine();
			string rol;

			  if (herramienta == "pistola") rol = "guardia de pato presidencial";
			  else if (herramienta == "diccionario") rol = "traductor de peces";
			  else if (herramienta == "alpiste") rol = "entrenador de palomas";
			  else if (herramienta == "pistola de etiquetar") rol = " Repartidor de paquetes";
			  else  {rol = "cuidador de plantas";}	
			  return rol; 
		}
	
	
	
	public static void Main()
	{
		
		
		Console.Write("Escribe tu nombre: ");
        string nombre = Console.ReadLine();                       
		string rol = trabajos();
		Jugador player = new Jugador(nombre, rol);
		player.mostrarPersoanje();
		
		
	}
}
