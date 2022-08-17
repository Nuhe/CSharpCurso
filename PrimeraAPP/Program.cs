using System;

namespace PrimeraAPP
{
    class Program
    {
        static void Main(String[] args)
        {
            int edadPersona1;
            int edadPersona2;
            int edadPersona3;
            int edadPersona4;

            edadPersona1 = edadPersona2 = edadPersona3 = edadPersona4 = 27;
            //Una manera linda para asignar el mismo valor a varias variables.

            

            string texto = "Gato";
            Console.WriteLine("Hello World! " + "Bye World! " + texto);
            Console.WriteLine($"Tienes un {texto}"); //Interpolacion de Strings
        }
    }
}

/*Los identificadores son los nombres que se usan para identificar los elementos de tus programas
-Namespaces
-Clases
-Metodos
-Variables
-Constantes
 */

/*
 Tipos de datos
    POR VALOR{
            Primitivos (Enteros, reales, booleanos)
            Estructuras
            Enumerados
        }
    POR REFERENCIA{
            Char, String
        }
*/

/*ENTEROS{
 *      Con signo {sbyte, short, int, long} (Maneja todos los numeros positivos.)
 *      Sin signo {byte, ushort, uint, ulong} (Maneja todos los numeros. Positivos y negativos. Pero su rango es mas corto)
 *       }*/

/*REALES{
 *  float, double, decimal (Que tan largo es el numero decimal)
 * }*/

/*BOOLEANOS{
 *  True, False.
 * }*/

/*TEXTO{
 *  Char, String (Char almacena un caracter. String una cadena de texto)
 *  }
 */
