using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Nina_0
{
    class Program
    {
        static void Main(string[] args)
        {
            int Edad;
            Console.WriteLine("Dime Tu edad:");
            Edad = int.Parse(Console.ReadLine());
            if(Edad < 18)
            {
                Console.WriteLine("Eres menor Pibe");
            }
            if(Edad >= 18)
            {
                Console.WriteLine("Eres mayor de edad aprobaste");
            }
            Console.ReadKey();
        }
    }
}
