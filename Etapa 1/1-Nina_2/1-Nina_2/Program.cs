using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Nina_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Dime un numero:");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Dime un numero:");
            num2 = int.Parse(Console.ReadLine());
            if (num2 == 0)
            {
                Console.WriteLine("Error el divisor es igual a 0");
            }
            else
            {
                Console.WriteLine("Tu division es " + (num1/num2));
            }
            Console.ReadKey();
        }
    }
}
