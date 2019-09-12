/*
 * Creado por SharpDevelop.
 * Usuario: Angarita
 * Fecha: 11/09/2019
 * Hora: 10:27 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace ejercicio5
{
	class Program
	{
		public static void Main(string[] args)
		{
			Caracter c = new Caracter();
        char Car;
        Console.WriteLine("dijite  una vocal o consonante");
        Car = Convert.ToChar(Console.ReadLine());
        c.Calcula(Car);
        Console.ReadLine();
    }
}

class Caracter
{

    public void Calcula(char Car)
    {
        switch (Car)
        {
            case 'a':
                Console.WriteLine("Es vocal "+Car);
                break;
            case 'e':
                Console.WriteLine("Es vocal "+Car);
                break;
            case 'i':
                Console.WriteLine("Es vocal "+Car);
                break;
            case 'o':
                Console.WriteLine("Es vocal "+Car);
                break;
            case 'u':
                Console.WriteLine("Es vocal "+Car);
                break;
			default:
                Console.WriteLine("Es una consonante "+Car);
                break;
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
}
