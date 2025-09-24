using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Nina_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result;
            result = Sumar();
            Console.WriteLine("El resultado es " + result);
            Console.ReadKey();
        }

        static int Sumar()
        {
            int Num1, Num2, Result;
            Console.WriteLine( "Ingrese un numero" );
            Num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero");
            Num2 = int.Parse(Console.ReadLine());

            Result = Num1 + Num2;

            return  Result;
        }
    }
}
