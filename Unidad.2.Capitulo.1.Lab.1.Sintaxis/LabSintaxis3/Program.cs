using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una frase");
            string texto = Console.ReadLine();
            Console.WriteLine();
            if (texto.Length <= 0)
            {
                Console.WriteLine("No se ingreso texto");
                Console.ReadKey();
            }
            Console.WriteLine("1- Mostrar en MAYUSCULAS");
            Console.WriteLine("2- Mostrar en Minusculas");
            Console.WriteLine("3- Mostrar largo del texto");
            Console.WriteLine();
            Console.WriteLine("Ingrese una opción");
            ConsoleKeyInfo op = Console.ReadKey();
            Console.WriteLine();
            Console.ReadKey();
            switch (op.KeyChar)
            {
                case '1': 
                    Console.WriteLine(texto.ToUpper());
                    Console.ReadKey();
                    break;
                case '2':
                    Console.WriteLine(texto.ToLower());
                    Console.ReadKey();
                    break;
                case '3':
                    Console.WriteLine(texto.Length);
                    Console.ReadKey();
                    break;
            }
        }
    }
}
