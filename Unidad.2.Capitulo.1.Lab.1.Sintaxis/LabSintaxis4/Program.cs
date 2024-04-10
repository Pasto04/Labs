using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = new string[] { "Juan", "Lourdes", "Pastorino", "Miguel Angel", "Isabella" };
            int cantItera = 5;
            for (int i = 0; i < cantItera; i++) {
                Console.WriteLine(array[cantItera -1 -i]);
                Console.WriteLine();}
            Console.ReadKey();
        }
    }
}
