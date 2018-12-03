using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RADIX
{
    public class RADIX
    {
        public int[] Arreglo;
        private List<List<int>> Digitos = new List<List<int>>();//LISTA DE LISTAS
        public RADIX(int[] Arreglo)//CONSTRUCTOR DE LA CLASE RADIX
        {
            for (int i = 0; i < Arreglo.Length; i++)//A CADA VALOR DEL ARREGLO LE SUMO 1,000,000 PARA QUE EN CASO DE SER NEGATIVO
            {//AUN ASI SE PUEDAN TOMAR LOS VALORES
                Arreglo[i] = Arreglo[i] + 1000000;
            }
            for (int i = 0; i < 10; i++)//SON LAS 10 COLUMNAS DONDE SE MANDAN LOS VALORES
            {
                Digitos.Add(new List<int>());
            }
            this.Arreglo = Arreglo; //INICIALIZACION DEL ARREGLO
        }

        public void RadixSort()
        {
            for (int i = 0; i < Arreglo.Length; i++)//PASA POR TODOS LOS NUMEROS DEL ARREGLO
            {
                for (int j = 0; j < Arreglo.Length; j++)
                {
                    int digito = (int)((Arreglo[j] % Math.Pow(10, i + 1)) / Math.Pow(10, i));//TOMA DIGITO POR DIGITO Y LOS COMPARA
                    Digitos[digito].Add(Arreglo[j]);
                }
                int varible = 0;
                for (int k = 0; k < Digitos.Count; k++)
                {
                    List<int> Acomodado = Digitos[k];//LISTA DONDE SE ACOMODAN LOS DATOS
                    for (int l = 0; l < Acomodado.Count; l++)
                    {
                        Arreglo[varible++] = Acomodado[l];
                    }
                }
                ClearDigits();//LIMPIEZA DE DATOS
            }
            Imprimir();//IMPRESION DE DATOS
        }

        private void ClearDigits()//METODO QUE LIMPIA EL ARREGLO AUXILIAR PARA ACOMODAR LOS DATOS
        {
            for (int k = 0; k < Digitos.Count; k++)
            {
                Digitos[k].Clear();//LIMPIA POSICIONES UNA POR UNA
            }
        }
        public void Imprimir()//METODO DE IMPRESION DE DATOS YA ORDENADOS
        {
            for (int i = 0; i < Arreglo.Length; i++)//LE RESTO 1,000,000 A CADA POSICION PARA PODER VOLVER LOS NUMEROS ORIGINALES
            {
                Arreglo[i] = Arreglo[i] - 1000000;
            }
            Console.WriteLine("\nLos numeros ya ordenados son : ");
            for (int i = 0; i < Arreglo.Length; i++)
            {
                Console.Write(Arreglo[i] + "  ");//IMPRESION
            }
        }
    }
}
