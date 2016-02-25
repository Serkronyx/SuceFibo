using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sucFibo
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = 12;
            int [] numfibo = new int [num];

            // da el limite de los numeros a imprimir 
            for (int i = 0; i < numfibo.Length; i++)
            {
                   //hace la condicion para imprimir los dos primero #1 
                    if (i <= 1)
                    {
                        numfibo[i] = 1;
                        Console.Write(numfibo[i] + " ");
                    }
                    else
                    {
                        //hace la suma del array empezando posiciones [0] y [1]
                        //y asi sucesivamente con un incremento de 1 en 1
                        numfibo[i] = numfibo[i - 2] + numfibo[i - 1];
                        Console.Write(numfibo[i] + " ");
                    }             
                    
            }
            Console.ReadKey();
        }
    }
}
