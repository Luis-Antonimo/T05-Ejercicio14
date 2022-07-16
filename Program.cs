using System;

namespace T05Ejercicio14
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("¿Qué longitud (entero positivo) quiere para el array?: ");
            int longitud = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[longitud];
            Random rnd = new Random();

            for (int i = 0; i < longitud; i++)
            {
                int aleatorio = rnd.Next(1, 11);//El valor máximo de rnd.Next no entra en el rango                
                array[i] = aleatorio;
            }

            Console.WriteLine("Escriba un número del 1 al 10 que crea que existe en el array generado: ");
            int valor = Convert.ToInt32(Console.ReadLine());
            //Utilizo el método .Contains de System-Linq
            //que busca en el array un valor y devuelve true o false.
            bool existe = array.Contains(valor);
            //Para la salida en pantalla utilizo esta construcción vista en los manuales de Microsoft
            //de C# que evita usar una construcción más larga con if/else.
            Console.WriteLine("El array {0} contiene '{1}'.", existe ? "sí" : "no", valor);
        }
    }
}