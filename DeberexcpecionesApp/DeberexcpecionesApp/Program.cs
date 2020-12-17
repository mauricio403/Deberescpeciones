using System;

namespace DeberexcpecionesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numero = new Random();

            int aleatorio = numero.Next(0, 100);

            int miNumero;

            int intentos = 0;

            Console.WriteLine("Introduce un numero de 0 a 100");

            do
            {
                intentos++;

                try
                {
                    miNumero = int.Parse(Console.ReadLine());

                } catch(FormatException ex)
                {
                    Console.WriteLine("No has introducido un valor numerico valido, vuelve a intentar");

                    miNumero = 0;
                }
                if (miNumero > aleatorio) Console.WriteLine("el numero es mas bajo");
                if (miNumero < aleatorio) Console.WriteLine("El numero es mas alto");

            } while (aleatorio != miNumero);
                Console.WriteLine($"Correcto! has necesitado  {intentos} intentos");

            Console.WriteLine("a partir de aqui el programa continuaria");
        }
    }
}
