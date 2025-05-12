using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;
            Console.WriteLine("¿Cual es tu edad?");
            edad = Convert.ToInt32(Console.ReadLine());
            if (edad >= 18)
                Console.WriteLine("Tu eres mayor de edad ");
            else
                Console.WriteLine("Tu eres menor de edad");

            Console.ReadKey();
        }
    }
}
