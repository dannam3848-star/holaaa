using System;
					
public class Program
{
	public static void Main()
	{
	   //datos//
	 Console.Write("¿Cómo te llamas? ");
        string nombre = Console.ReadLine();
		 ///decicioness del jugador///
		 Console.WriteLine("\n--- Creación de personaje ---");
        Console.WriteLine("Elige una herramienta:");
        Console.WriteLine("1. arco");
        Console.WriteLine("2. cuchilla");
        Console.WriteLine("3. libro magico");
        Console.WriteLine("4. Kit de ingeniería");
        Console.Write("Opción (1-4): ");
        int herramienta = int.Parse(Console.ReadLine());
		
		
        Console.WriteLine("¿cual es tu color favorito?:");
        Console.WriteLine("1. azul");
        Console.WriteLine("2. rojo");
        Console.WriteLine("3. morado");
        Console.WriteLine("4. naranja");
        Console.Write("Opción (1-4): ");
        int color = int.Parse(Console.ReadLine());
		
		Console.WriteLine("¿te gusta el tè?(s/n):");
		string gustaTe = Console.ReadLine().ToLower();
		
		 Console.Write("¿Cuántas horas al día te gusta explorar? (0-24): ");
        int horasExplorar = int.Parse(Console.ReadLine());

		
		  ///variables del personaje///
		
		   string rol = "";
        int velocidad = 0;
        int fuerza = 0;
        int inteligencia = 0;
        int resistencia = 0;

        // ========== 4. Lógica de decisión (condicionales) ==========
        // Combinamos varias respuestas + operadores y if anidados

        if (herramienta == 1)                          // Espada
        {
            if (color == 1 || color == 4)              // Rojo o Negro
            {
                rol = "casador";
                velocidad = 50;
                fuerza = 90;
                inteligencia = 40;
                resistencia = 80;
            }
            else if (color == 2 && gustaTe == "n")
            {
                rol = "casador";
                velocidad = 55;
                fuerza = 85;
                inteligencia = 45;
                resistencia = 75;
            }
            else
            {
                rol = "mago";
                velocidad = 80;
                fuerza = 60;
                inteligencia = 50;
                resistencia = 70;
            }
        }
        else if (herramienta == 2)                     // Bastón mágico
        {
            if (gustaTe == "s" && color != 1)
            {
                rol = "bestia";
                velocidad = 40;
                fuerza = 30;
                inteligencia = 95;
                resistencia = 50;
            }
            else if (horasExplorar >= 5)
            {
                rol = "Curandero";
                velocidad = 45;
                fuerza = 35;
                inteligencia = 85;
                resistencia = 65;
            }
            else
            {
                rol = "bestia";
                velocidad = 35;
                fuerza = 25;
                inteligencia = 90;
                resistencia = 45;
            }
        }
        else if (herramienta == 3)                     // Mochila de exploración
        {
            if (horasExplorar > 8 && color == 3)
            {
                rol = "mago";
                velocidad = 95;
                fuerza = 55;
                inteligencia = 60;
                resistencia = 70;
            }
            else if (horasExplorar <= 4 || color == 4)
            {
                rol = "Ingeniero";
                velocidad = 60;
                fuerza = 50;
                inteligencia = 80;
                resistencia = 55;
            }
            else
            {
                rol = "mago";
                velocidad = 85;
                fuerza = 50;
                inteligencia = 55;
                resistencia = 65;
            }
        }
        else if (herramienta == 4)                     // Kit de ingeniería
        {
            if (!(gustaTe == "s") && color != 2)
            {
                rol = "Ingeniero";
                velocidad = 55;
                fuerza = 45;
                inteligencia = 90;
                resistencia = 60;
            }
            else
            {
                // if anidado
                if (horasExplorar >= 6)
                {
                    rol = "Curandero";
                    velocidad = 50;
                    fuerza = 40;
                    inteligencia = 75;
                    resistencia = 70;
                }
                else
                {
                    rol = "Ingeniero";
                    velocidad = 65;
                    fuerza = 50;
                    inteligencia = 85;
                    resistencia = 55;
                }
            }
        }
        else
        {
            // Opción inválida → personaje por defecto
            rol = "mago";
            velocidad = 70;
            fuerza = 50;
            inteligencia = 50;
            resistencia = 60;
        }

        // Ajuste extra con operadores relacionales y lógicos
        if (horasExplorar > 12 && velocidad < 90)
        {
            velocidad += 10;   // Bonus por mucha exploración
        }

        if (gustaTe == "s" && inteligencia >= 80)
        {
            inteligencia += 5; // Pequeño bonus
        }
      
			     // ========== 5. Resultado final ==========
        Console.WriteLine("\n=================================");
        Console.WriteLine("       PERSONAJE CREADO");
        Console.WriteLine("=================================");
        Console.WriteLine($"Nombre del jugador : {nombre}");
        Console.WriteLine($"Rol                : {rol}");
        Console.WriteLine($"Velocidad          : {velocidad}");
        Console.WriteLine($"Fuerza             : {fuerza}");
        Console.WriteLine($"Inteligencia       : {inteligencia}");
        Console.WriteLine($"Resistencia        : {resistencia}");
        Console.WriteLine("=================================");
			
	  }
		
	}
