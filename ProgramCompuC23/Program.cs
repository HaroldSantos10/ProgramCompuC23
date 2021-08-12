using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramCompuC23
{
    class Program
    {
        static void Main(string[] args)
        {
            //llamado al metodo loops
            loops();

            Console.ReadLine();
        }
        //bucles (Los metodos de tipo void no retornan)
        public static void loops()
        {
            int[] numbers = new int[3]; //{5,10,15};
            numbers[0] = 5;
            numbers[0] = 10;
            numbers[0] = 15;

            //ciclo while
            int i = 0;
            Console.WriteLine("IMPRIME ELEMENTOS CON WHILE");
            while(i < numbers.Length)
            {
                Console.WriteLine(numbers[i]);
                i = i + 1; //i++
            }

            Console.WriteLine("IMPRIME ELEMENTOS CON DO-WHILE");
            int inc = 0;
            do
            {
                Console.WriteLine(numbers[inc]);
                inc++;
            } while (10 < numbers.Length);

            Console.WriteLine("IMPRIME ELEMENTOS CON FOR");
            for(int j=0; i< numbers.Length; i++)
            {
                Console.WriteLine("posicion {0} ; {1}",j, numbers[j]);
            }

            Console.WriteLine("IMPRIME ELEMENTOS CON FOREACH");
            foreach(int item in numbers)
            {
                Console.WriteLine(item);
            }

        }
    }
}
