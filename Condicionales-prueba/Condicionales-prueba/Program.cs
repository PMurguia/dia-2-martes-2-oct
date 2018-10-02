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


            //Pedimos un número del 1 al 7 y lo traducimos al día de la semana correspondiente

            int numSem; //establecemos variable
            Console.WriteLine("Dime un número del 1 al 7."); //Mensaje en pantalla
            numSem = Int32.Parse(Console.ReadLine()); //Guardamos el valor dado por el usuario en la variable

            if (numSem == 1) //Si el número es un uno
            {
                Console.WriteLine("Ese número corresponde al lunes."); //Salta este mensaje
            }
            else if (numSem == 2) //Si el número es un dos
            {
                Console.WriteLine("Ese número corresponde al martes."); //Salta este mensaje
            }
            else if (numSem == 3) //Si el número es un tres
            {
                Console.WriteLine("Ese número corresponde al miércoles."); //Salta este mensaje
            }
            else if (numSem == 4) //Si el número es un cuatro
            {
                Console.WriteLine("Ese número corresponde al jueves."); //Salta este mensaje
            }
            else if (numSem == 5) //Si el número es un cinco
            {
                Console.WriteLine("Ese número corresponde al viernes."); //Salta este mensaje
            }
            else if (numSem == 6) //Si el número es un seis
            {
                Console.WriteLine("Ese número corresponde al sábado."); //Salta este mensaje
            }
            else if (numSem == 7) //Si el número es un siete
            {
                Console.WriteLine("Ese número corresponde al domingo."); //Salta este mensaje
            }
            else //Si han introducido un número que no está dentro del rango solicitado
            {
                Console.WriteLine("No es un número del 1 al 7."); //Salta este mensaje
            }
            Console.ReadLine();
        }
    }
}
