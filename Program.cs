using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace burbujasprueba
{
    internal class Program
    {
        static int[] numeros = new int[] { 10, 2, 3, 4, 5, 1, 9 };
        static void Main(string[] args)
        {
            Console.WriteLine("inicio");
            mostar();
            for(int i =0; i < numeros.Length; i++)
            {

            }
        }
        public static void mostar()//unicamente muestra el resultado
        {
            foreach (var numeros in numeros)
            {
                Console.WriteLine(numeros + ",");
            }
            Console.WriteLine("\n");
            
        }
    }
}
