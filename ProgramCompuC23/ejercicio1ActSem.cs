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
            // 1. escribir un ciclo que permita capturar los valores
            // almacenar en el arreglo de numbers con un tamaño de 10

            //2. calcular el promedio de los numeros almacenados en el array


            int[] numeros = new int[10];
            int suma = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"introduce el #{i+1} numero");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
                suma = suma + numeros[i];
            }
            Console.WriteLine("Estos son los numeros");
            foreach (int item in numeros)
            {
                Console.WriteLine(item);
                
            }


            Console.WriteLine($"El promedio es: {suma/(numeros.Length)}");

            Console.ReadKey();


        }
    }
}
