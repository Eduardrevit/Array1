using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine("Введите целочисленное значение");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[n, n];
            {

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (((i % 2 == 0) && (j % 2 == 0)) || (i % 2 != 0) && (j % 2 != 0))
                            array[i, j] = 1; 

                Console.Write("{0,4} ", array[i, j]);

                    }

                    Console.WriteLine();
                }

                Console.ReadKey();
            }
        }
    }
}
