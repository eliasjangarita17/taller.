/*
 * Creado por SharpDevelop.
 * Usuario: Angarita
 * Fecha: 11/09/2019
 * Hora: 10:40 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace ejercicio7
{
	class Program
	{
		public static void Main(string[] args)
		{
int num1,num2,num3;
Console.WriteLine("dijite un número");
num1= int.Parse(Console.ReadLine());
Console.WriteLine("dijite un número");
num2= int.Parse(Console.ReadLine());
Console.WriteLine("dijite un número");
num3= int.Parse(Console.ReadLine());
if(num1>num2 && num1>num3){
Console.WriteLine("el número"+num1+"es el mayor");
}else if(num2>num1 && num2>num3){
Console.WriteLine("el número"+num2+"es el mayor");
}else if(num3>num1 && num3>num2){
Console.WriteLine("el número"+num3+"es el mayor");
}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}