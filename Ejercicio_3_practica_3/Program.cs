using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3_practica_3
{
    class Program
    {
        static void Main(string[] args)

            
        {

            double numero ,suma;

            do
            {

                Console.WriteLine("Digite un numero");
                numero = Convert.ToDouble(Console.ReadLine());

            } while (numero  !=0);

            suma = numero + numero;

            Console.WriteLine("El resultado es" + suma);


            Console.ReadKey();
       
        }
        


    }
}
