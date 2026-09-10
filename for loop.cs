using System;
					
public class Program
{
	public static void Main()
	{
		string linea1= "";
			for (int i = 0; i < 8; i++)
			{
				linea1 += "x";
			}
		Console.WriteLine(linea1);  
		string [] simbolos = {"x", "O", "x", "O", "x"};
	    int[] repeticiones = {2, 1, 2, 1, 2};
		
		 string linea2 = "";
			
			 for (int i = 0; i< simbolos.Length; i++)
			{
			  string l = simbolos[i];
			  int r = repeticiones[i];
			  for (int j = 0; j< r; j++)
				{	 
					linea2 += l; 
			    }      	 
			} 
	Console.WriteLine(linea2);
		
		string [] sim = {"x", "(", "-", ")", "x"};
	    int[] rep = {2, 1, 2, 1, 2};
		
		 string linea3 = "";
		 for (int k = 0; k < sim.Length; k++)
		 {	
			 string letra = sim [k];
			 int repeticion = rep[k];
			 for (int h = 0; h <  repeticion; h++)
			 {
				linea3 += letra; 
			 }	   
		 }
		Console.WriteLine(linea3);
	}
}
