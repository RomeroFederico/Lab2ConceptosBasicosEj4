using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_4
{

    /*
    04.  Un número perfecto es un entero positivo, que es igual a la suma 
    de todos los enteros positivos (excluido el mismo) que son 
    divisores del número.  
    El primer número perfecto es 6, ya que los divisores de 6 son 1, 
    2 y 3; y 1 + 2 + 3 = 6.  
    Escribir una aplicación que encuentre los 4 primeros números 
    perfectos. 
  
    Nota: Utilizar estructuras repetitivas, selectivas y la función 
    módulo (%).
    */

    class Ejercicio_4
    {
        static void Main(string[] args)
        {
            int num;
            int divisores = 0;
            int cont = 0;

            Console.Title = "Ejercicio Nro. 4";

            Console.WriteLine("Los primeros 6 numeros perfectos son: ");

            for (num = 1; cont < 4; num++, divisores = 0)
            {
                for (int i = 1; i < num; i++)
                {
                    if (num % i == 0)
                        divisores += i;
                }

                if (divisores == num)
                {
                    Console.WriteLine(num);
                    cont++;
                }
            }

            Console.ReadKey();
        }
    }
}