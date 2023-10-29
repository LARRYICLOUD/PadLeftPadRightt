using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadLeftPadRightt
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("YO SOY UN PROGRAMADOR Y EXPERTO EN REDES EXCELENTE Y RECONOCIDO");

            String cadena1 = "Hola a todos";
            Console.WriteLine(cadena1);
            //Despues de PadLeft rellena los espacios e blanco ya qu la cadena tiene  solo 13 elementos
            Console.WriteLine(cadena1.PadLeft(15));

            //PadRight rellenamos con un caracter los 3 espacios
            Console.WriteLine(cadena1.PadRight(15, '#'));









        }
    }
}
