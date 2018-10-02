using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionales_prueba
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pedir dos números y decir si son iguales o no.

            int num1; //Primer número
            int num2; //Segundo número
            Console.WriteLine("Introduce un número. "); //Pedimos un número
            num1 = Int32.Parse(Console.ReadLine()); //Usuario introduce número y lo guardamos
            Console.WriteLine("Introduce otro número. "); //Pedimos otro
            num2 = Int32.Parse(Console.ReadLine()); // Usuario introduce otro numero y lo guardamos

            if (num1 == num2) //Comparamos si son iguales o no.
            {
                Console.WriteLine("Los números son iguales. Qué poca imaginación. "); //Si son iguales, salta este mensaje
            }
            else //Si no son iguales
            {
                Console.WriteLine("Los números no son iguales. "); //Salta este mensaje
            }
            Console.ReadLine();


            //Pedimos un número y que el programa diga si es par o impar.

            int parImpar1; //Variable del número
            Console.WriteLine("Introduce un número. "); //Usuario introduce número
            parImpar1 = Int32.Parse(Console.ReadLine()); //Guardamos valor en variable

            if (parImpar1 % 2 == 0) // Comparamos si el resto de dividir el número introducido entre 2 es 0
            {
                Console.WriteLine("El número seleccionado es par. "); //Si el resultado es 0, el número es par, por lo que salta este mensaje
            }
            else //En caso de que el resto de 1
            {
                Console.WriteLine("El número introducido es impar. "); //El número es impar y salta este mensaje
            }
            Console.ReadLine();

            int numSem;
            Console.WriteLine("Dime un número del 1 al 7.");
            numSem = Int32.Parse(Console.ReadLine());

            if (numSem == 1)
            {
                Console.WriteLine("Ese número corresponde al lunes.");
            }
            else if (numSem == 2)
            {
                Console.WriteLine("Ese número corresponde al martes.");
            }
            else if (numSem == 3)
            {
                Console.WriteLine("Ese número corresponde al miércoles.");
            }
            else if (numSem == 4)
            {
                Console.WriteLine("Ese número corresponde al jueves.");
            }
            else if (numSem == 5)
            {
                Console.WriteLine("Ese número corresponde al viernes.");
            }
            else if (numSem == 6)
            {
                Console.WriteLine("Ese número corresponde al sábado.");
            }
            else
            {
                Console.WriteLine("Ese número corresponde al domingo.");
            }
            Console.ReadLine();
        }
    }
}
