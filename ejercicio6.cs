/*
 * Creado por SharpDevelop.
 * Usuario: Angarita
 * Fecha: 11/09/2019
 * Hora: 10:31 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace ejercicio6
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			double n,FN;
			Console.readline("dijite n");
			n= Convert.ToDouble(Console.readline());
			FN=1/Math.Sqrt(5)*Math.Pow((1+Math.Sqrt(5)/2),n)-Math.Pow((1+Math.Sqrt(5)/2),n);
			Console.WriteLine(FN);

			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}