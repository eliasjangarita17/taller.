/*
 * Creado por SharpDevelop.
 * Usuario: Angarita
 * Fecha: 11/09/2019
 * Hora: 9:42 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace ejercicio1
{
	class Program
	{
		public static void Main(string[] args)
		{
			int num1,num2,eleccion,resultado;
			Console.WriteLine("dijite un numero");
			num1=int.Parse(Console.ReadLine());
			
			Console.WriteLine("dijite otro numero");
			num2=int.Parse(Console.ReadLine());
			
			Console.WriteLine("las opciones son");
			Console.WriteLine("1-adicion");
			Console.WriteLine("2-sustraccion");
			Console.WriteLine("3-multiplicacion");
			Console.WriteLine("4-divicion");
			eleccion=int.Parse(Console.ReadLine());
			if(eleccion==1){
			resultado=num1+num2;
			Console.WriteLine("el resultado es:"+resultado);
			}else if(eleccion==2){
			resultado=num1-num2;
			Console.WriteLine("el resultado es:"+resultado);
			}else if(eleccion==3){
			resultado=num1*num2;
			Console.WriteLine("el resultado es:"+resultado);
			}else if(eleccion==4){
			resultado=num1/num2;
			Console.WriteLine("el resultado es:"+resultado);
			}
			
			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}