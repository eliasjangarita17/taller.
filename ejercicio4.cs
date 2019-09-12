/*
 * Creado por SharpDevelop.
 * Usuario: Angarita
 * Fecha: 11/09/2019
 * Hora: 10:15 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace ejercicio4
{
	class Program
	{
		public static void Main(string[] args)
		{
string nombre;
int consumo;
Console.WriteLine("dijite el conso de la electricidad");
consumo=int.Parse(Console.ReadLine());
if(consumo<=199){
	Console.WriteLine("el señor(a)"+nombre+"debe pagar 1,20" );
}else if(consumo>=200){
Console.WriteLine("el señor(a)"+nombre+"debe pagar 1,50" );
}else if(consumo>=400){
Console.WriteLine("el señor(a)"+nombre+"debe pagar 1,80" );
}else if(consumo>=600){
Console.WriteLine("el señor(a)"+nombre+"debe pagar 2,00" );
}



			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}