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
            Random rand = new Random();
            int Ta = 4;
            int[] vec = new int [Ta];

            int[,] Matriz = new int[Ta,Ta];
            for (int i = 0; i < Ta; i++)
            {
                for (int j = 0; j < Ta; j++)
                {
                    int num = rand.Next(1, 25);
                    Matriz[i, j] = num;
                }
            }
            for (int i = 0; i < Ta; i++)
            {
                vec[i] = Matriz[i, i];
                Console.WriteLine(vec[i]);
                Console.Write(" ");
            }
            Console.ReadKey();
        }
    }
}
