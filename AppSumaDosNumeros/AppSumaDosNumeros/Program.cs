using System;

namespace AppSumaDosNumeros
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//declaracion de variables
			int numero1, numero2, suma;
			string linea;
			Console.WriteLine ("Programa que calcula la suma de 2 numeros");
			Console.WriteLine ("Digite Numero 1:");
			linea = Console.ReadLine ();
			numero1 = int.Parse (linea);
			Console.WriteLine ("Digite Numero 2:");
			linea = Console.ReadLine ();
			numero2 = int.Parse (linea);
			suma = numero1 + numero2;
			Console.WriteLine ("La suma es:"+suma);
			Console.ReadKey ();
		}
	}
}
