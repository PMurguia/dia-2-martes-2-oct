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
            Console.WriteLine("Dime un número del 1 al 7. Lo traduciremos al día de la semana correspondiente."); //Mensaje en pantalla
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

            //Pedir por teclado un numero de mes y traducirlo.

            int mes; //Generamos variable para guardar el valor
            Console.WriteLine("Introduce un número de mes. "); //Pedimos un número
            mes = Int32.Parse(Console.ReadLine()); //Lo guardamos en la variable generada

            switch (mes) // Tomando el valor que introduce el usuario,
            {
                case 0: // Si introduce este valor (repetir para cada "case")
                    Console.WriteLine("Definitivamente ESE NÚMERO NO CORRESPONDE A UN MES."); //saldrá este mensaje (repeat for every sentence)
                    break; //Se ejecutará si el valor introducido por el usuario corresponde a este caso (repetir para cada "break")
                case 1:
                    Console.WriteLine("Ese mes es enero.");
                    break;
                case 2:
                    Console.WriteLine("Ese mes e febrero.");
                    break;
                case 3:
                    Console.WriteLine("Ese mes es marzo.");
                    break;
                case 4:
                    Console.WriteLine("Ese mes es abril.");
                    break;
                case 5:
                    Console.WriteLine("Ese mes es mayo.");
                    break;
                case 6:
                    Console.WriteLine("Ese mes es junio.");
                    break;
                case 7:
                    Console.WriteLine("Ese mes es julio.");
                    break;
                case 8:
                    Console.WriteLine("Ese mes es agosto.");
                    break;
                case 9:
                    Console.WriteLine("Ese mes es septiembre.");
                    break;
                case 10:
                    Console.WriteLine("Ese mes es octubre.");
                    break;
                case 11:
                    Console.WriteLine("Ese mes es noviembre.");
                    break;
                case 12:
                    Console.WriteLine("Ese mes es diciembre.");
                    break;
                default: //Si introduce un valor que no está determinado en los "case", salta "default"
                    Console.WriteLine("No hay ningún mes después del 12, alicate. "); //Y salta este mensaje
                    break; //Y termina la ejecución
            }
            Console.ReadLine();


            //establecer clasificación en función de la nota

            double nota;
            Console.WriteLine("¿Qué nota has sacado?. ");
            nota = Double.Parse(Console.ReadLine());

            if (nota < 5)
            {
                Console.WriteLine("Suspenso. ");
            }
            else if (nota >= 5 && nota < 6)
            {
                Console.WriteLine("Aprobado. ");
            }
            else if (nota >= 6 && nota < 7)
            {
                Console.WriteLine("Bien. ");
            }
            else if (nota >= 7 && nota < 8)
            {
                Console.WriteLine("Muy Bien. ");
            }
            else if (nota >= 8 && nota < 9)
            {
                Console.WriteLine("Notable");
            }
            else if (nota >= 9 && nota <= 10)
            {
                Console.WriteLine("Sobresaliente. ");
            }
            Console.ReadLine();
        

            //Pedir por teclado peso y alura e indicar por IMC cual es su clasificación

            double altura; //Creamos variable para valor altura
            double peso; //Creamos variable para valor peso
            Console.WriteLine("Introduce tu altura en metros. "); //Pedimos altura
            altura = Double.Parse(Console.ReadLine()); //Guardamos valor en variable
            Console.WriteLine("Introduce tu peso en kilos. "); //Pedimos peso
            peso = Double.Parse(Console.ReadLine()); //Guardamos valor en variable
            double imc = peso / Math.Pow(altura, 2); // Establecemos variable imc Y le damos un valor en forma de fórmula
            Console.WriteLine("Tu IMC es " + imc); //Muestra en pantalla el imc calculado
            if (imc < 16.00) // Empezamos a comparar en qué clasificación de la tabla de la OMS está ese imc (igual que ejer. anterior)
            {
                Console.WriteLine("Delgadez severa. ");
            }
            else if (imc >= 16.00 && imc <= 16.99)
            {
                Console.WriteLine("Infrapeso: Delgadez moderada. ");
            }
            else if (imc >= 17.00 && imc <= 18.49)
            {
                Console.WriteLine("Infrapeso: Delgadez acepable. ");
            }
            else if (imc >= 18.50 && imc <= 24.99)
            {
                Console.WriteLine("Peso normal. ");
            }
            else if (imc >= 25.00 && imc <= 29.99)
            {
                Console.WriteLine("Sobrepeso. ");
            }
            else if (imc >= 30.00 && imc <= 34.99)
            {
                Console.WriteLine("Obeso: Tipo I. ");
            }
            else if (imc >= 35.00 && imc <= 40.00)
            {
                Console.WriteLine("Obeso: Tipo II. ");
            }
            else if (imc > 40.00)
            {
                Console.WriteLine("Obeso: Tipo III. ");
            }
            Console.ReadLine();




        }
    }
}
