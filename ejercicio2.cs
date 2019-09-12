/*
 * Creado por SharpDevelop.
 * Usuario: Angarita
 * Fecha: 11/09/2019
 * Hora: 9:55 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace ejercicio2
{
	class Program
	{
		public static void Main(string[] args)
		{
			string eleccion;
			int baseo,altura,resultado,radio;
			double Math.PI;
			Console.WriteLine("dijite 1 para el area del circulo");
			Console.WriteLine("dijite 2 para el area del rectangulo");
			Console.WriteLine("dijite 3 para el area del triangulo");
			eleccion=string.parse(Console.ReadLine());
			if(eleccion==1){
				Console.WriteLine("dijite el radio del circulo");
				radio=int.Parse(Console.ReadLine());
				resultado=Math.PI*(radio*radio);
				Console.WriteLine("el area del circulo es:"+resultado);
			
			}else if(eleccion==2){
			
				Console.WriteLine("dijite la base");
				baseo=int.Parse(Console.ReadLine());
				Console.WriteLine("dijite la altura");
				altura=int.Parse(Console.ReadLine());
				resultado=baseo*altura;
				Console.WriteLine("el area del rectangulo es:"+resultado);
			}else if(eleccion==3){
				
			
				Console.WriteLine("dijite la base");
				baseo=int.Parse(Console.ReadLine());
				Console.WriteLine("dijite la altura");
				altura=int.Parse(Console.ReadLine());
				resultado=baseo*altura;
				Console.WriteLine("el area del triangulo es:"+resultado);
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}