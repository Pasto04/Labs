using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una frase");
            string inputTexto = Console.ReadLine();
            if (inputTexto.Length <= 0 )
            {
                Console.WriteLine("No se ingreso Texto");
            }
            Console.WriteLine("1- " + inputTexto.ToUpper());
            Console.WriteLine ("2- " + inputTexto .ToLower());
            Console.WriteLine("3- " + inputTexto.Length);
            Console.WriteLine("Elija la opcion que desee");
            ConsoleKeyInfo op = Console.ReadKey();
            Console.ReadKey();
            if (op.Key == ConsoleKey.D1)
            {
                Console.WriteLine();
                Console.WriteLine(inputTexto.ToUpper());
                Console.ReadKey();
            }
            if (op.Key == ConsoleKey.D2)  
            {
                Console.WriteLine();
                Console.WriteLine (inputTexto.ToLower());
                Console.ReadKey();
            }
            if(op.Key == ConsoleKey.D3)
            {
                Console.WriteLine();
                Console.WriteLine(inputTexto.Length);
                Console.ReadKey();
            }
            if (op.Key != ConsoleKey.D1 || op.Key != ConsoleKey.D2 || op.Key != ConsoleKey.D3)
            {
                Console.WriteLine();
                Console.WriteLine("No se ingreso ninguno valor correcto");
                Console.ReadKey();
            }
        }
    }
}
