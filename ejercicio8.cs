/*
 * Creado por SharpDevelop.
 * Usuario: Angarita
 * Fecha: 11/09/2019
 * Hora: 10:45 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace ejercicio8
{
	class Program
	{
		public static void Main(string[] args)
		{
			double precio,descuento,total;
			Console.WriteLine("dijite el precio del articulo");
			precio=double.Parse(Console.ReadLine());
			if(precio>=200){
				descuento=precio*0.15;
				total=precio-descuento;
				Console.WriteLine("el costo es de"+precio+"el descuento es de"+descuento+"y el total a pagar es"+total);
			}else if(precio>100&<200){
			descuento=precio*0.12;
				total=precio-descuento;
				Console.WriteLine("el costo es de"+precio+"el descuento es de"+descuento+"y el total a pagar es"+total);
			}else if(precio>100){
			descuento=precio*0.10;
				total=precio-descuento;
				Console.WriteLine("el costo es de"+precio+"el descuento es de"+descuento+"y el total a pagar es"+total);
			}
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}