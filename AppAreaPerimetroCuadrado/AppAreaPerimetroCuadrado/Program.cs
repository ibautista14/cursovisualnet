using System;

namespace AppAreaPerimetroCuadrado
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			float lado, area, perimetro;
			Console.WriteLine ("Programa qe calcula el area y perimetro de un cuadrado");
			Console.WriteLine ("Digite lado:");
			lado = float.Parse (Console.ReadLine());
			area = lado * lado;  
			Console.WriteLine ("El area de un cuadrado:"+area);
			perimetro = 4 * lado;
			Console.WriteLine ("El perimetro es:" + perimetro);
			Console.ReadKey ();
		
		}
	}
}
