using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Nina_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opc = 0, Resultado;

            do
            {
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("1-Sumar");
                Console.WriteLine("2-Restar");
                Console.WriteLine("3-Multiplicar");
                Console.WriteLine("4_Dividir");
                Console.WriteLine("Ingrese la opcion:");
                opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        {
                            Resultado = Sumar();
                            Console.WriteLine("La suma es " + Resultado);
                        }
                        break;
                    case 2:
                        {
                            Resultado = Resta();
                            Console.WriteLine("La Resta es " + Resultado);
                        }
                        break;
                    case 3:
                        {
                            Resultado = Multiplicar();
                            Console.WriteLine("La multiplicacion es " + Resultado);
                        }
                        break;
                    case 4:
                        {
                            Resultado = Division();
                            Console.WriteLine("La division es " + Resultado);
                        }
                        break;
                    case 5:
                        {
                            Console.WriteLine("Saliendo del Sistema...");
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("Esta opcion es invalida");
                        }
                        break;
                }


            } while (opc != 5);
        }
        
        static int Sumar()
        {
            int Num1, Num2, Result;
            Console.WriteLine("Ingrese un numero ");
            Num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese un numero ");
            Num2 = int.Parse(Console.ReadLine());

            Result = Num1 + Num2;

            return Result;
        }
        static int Resta()
        {
            int Num1, Num2, Result;
            Console.WriteLine("Ingrese un numero ");
            Num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese un numero ");
            Num2 = int.Parse(Console.ReadLine());

            Result = Num1 - Num2;

            return Result;
        }
        static int Multiplicar()
        {
            int Num1, Num2, Result;
            Console.WriteLine("Ingrese un numero ");
            Num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese un numero ");
            Num2 = int.Parse(Console.ReadLine());

            Result = Num1 * Num2;

            return Result;
        }
        static int Division()
        {
            int Num1, Num2, Result;
            Console.WriteLine("Ingrese un numero ");
            Num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese un numero ");
            Num2 = int.Parse(Console.ReadLine());
            if (Num2 == 0)
            {
                Console.WriteLine("Ingrese de nuevo otro numero");
                Num2 = int.Parse(Console.ReadLine());
            }

            Result = Num1 / Num2;

            return Result;
        }
    }
}
