/*
 * Creado por SharpDevelop.
 * Usuario: SANDRANET
 * Fecha: 11/09/2019
 * Hora: 3:54 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace taller_condicionales
{
	class Program
	{
		public static void Main(string[] args)
		{
int num;
Console.WriteLine("dijite un numero");
num=int.Parse(Console.ReadLine());
if(num=1){
Console.WriteLine("el mes es enero y tiene 31dias");
}else if(num==2){
Console.WriteLine("el mes es febrero y tiene 28dias");
}else if(num==3){
Console.WriteLine("el mes es mayo y tiene 31 dias");
}else if(num==4){
Console.WriteLine("el mes es abril y tiene 30 dias");
}else if(num==5){
Console.WriteLine("el mes es marzo y tiene 30 dias");
}else if(num==6){
Console.WriteLine("el mes es junio y tiene 30 dias");
}else if(num==7){
Console.WriteLine("el mes es julio y tiene 31 dias");
}else if(num==8){
Console.WriteLine("el mes es agosto y tiene 30 dias");
}else if(num==9){
Console.WriteLine("el mes es septiembre y tiene 30 dias");
}else if(num==10){
Console.WriteLine("el mes es octubre y tiene 31 dias");
}else if(num==11){
Console.WriteLine("el mes es noviembre y tiene 30 dias");
}else if(num==12){
Console.WriteLine("el mes es diciembre y tiene 31 dias");
}

			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}