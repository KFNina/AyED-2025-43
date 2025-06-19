using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Nina_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string Contraseña, Ingresar;
            Contraseña = "niidea".ToUpper();
            Console.WriteLine("Ingrese la contraseña");

            Ingresar = Console.ReadLine().ToUpper();
            if (Ingresar == Contraseña)
            {
                Console.WriteLine("Joya, Contraseña conrrecta");
                Console.WriteLine(Contraseña);
            }
            else
            {
                Console.WriteLine("La contraseña incorrecta");
            }
            Console.ReadKey();
        }
    }
}
