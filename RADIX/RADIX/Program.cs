using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RADIX
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Arreglo = new int[] { 3, 6, 9, 5, 1, 4, 7, 2, 1, 3 };//ARREGLOS A ORDENAR
            int[] Arreglo2 = new int[] { 8, 3, 9, 3, 11, 7, 1, 27, 12 };
            int[] Arreglo3 = new int[] { 10, 40, 36, 5, 24, 2, 5, 8 };
            int[] Arreglo4 = new int[] { 55, 42, 0, -3, 0, -1, 2, 4, 7 };
            int[] Arreglo5 = new int[] { 25, 108, 1024, 12, 351, 251, 39 };
            new RADIX(Arreglo).RadixSort();//LLAMADA DE LOS METODOS
            new RADIX(Arreglo2).RadixSort();
            new RADIX(Arreglo3).RadixSort();
            new RADIX(Arreglo4).RadixSort();
            new RADIX(Arreglo5).RadixSort();
            Console.ReadKey(true);
        }
    }
}

