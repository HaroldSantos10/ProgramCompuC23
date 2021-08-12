using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramCompuC23
{
    class ejercicio1ActSem
    {
        static void Main(string[] args)
        {
            //escribir un ciclo que permita capturar los valores
            // almacenar en el arreglo de numbers con un tamaño de 10

            int[] numeros = new int[10];

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"introduce el #{i+1} numero");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
                
            }
            Console.WriteLine("Estos son los numeros");
            foreach (int item in numeros)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
