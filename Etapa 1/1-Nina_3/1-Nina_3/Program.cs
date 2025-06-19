using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Nina_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Dime un numero");
            num = int.Parse(Console.ReadLine());

            if (num %2 == 0)
            {
                Console.WriteLine("Tu numero es par");

            }
            else
            {
                Console.WriteLine("Tu numero es impar");
            }
            if (num == 0)
            {
                Console.WriteLine("Tu numero es cero Pibe");
            }
            Console.ReadKey();
        }
    }
}
