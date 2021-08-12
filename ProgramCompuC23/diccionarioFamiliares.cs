using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramCompuC23
{
    class diccionarioFamiliares
    {
        static void Main(string[] args)
        {
            /*crear un diccionario con los datos de 4 familiares,
            almacena el nombre y la edad, incluya sus datos y muestrelos ordenados
             */
            Dictionary<string, int> Familia = new Dictionary<string, int>();
            Familia.Add("Jorge Santos", 44);
            Familia.Add("Milagro Morillo", 44);
            Familia.Add("Rosmery Santos", 10);
            Familia.Add("Harold Santos", 19);

            foreach (KeyValuePair<string, int> familiar in Familia)
            {
                Console.WriteLine("Clave: {0}, valor: {1}", familiar.Key, familiar.Value);
            }

            //ordenados
            var dic = Familia.Keys.ToList();
            dic.Sort();
            Console.WriteLine("Diccionario ordenado");

            foreach (var item in dic)
            {
                Console.WriteLine("{0}: {1}", item, Familia [item]);
            }


            Console.ReadKey();
        }
    }
}
