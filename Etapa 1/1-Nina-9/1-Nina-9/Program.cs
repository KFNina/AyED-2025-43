using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Nina_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Dime un numero positivo:");
            num = int.Parse(Console.ReadLine());
            while(num != 0)
            {
                num = num - 1;
                Console.WriteLine(num);
            }
            Console.ReadKey();
        }
    }
}
