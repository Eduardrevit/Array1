using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 7;
            float S = 0;
            int[] array = new int[n];
            Console.WriteLine("Введите числа");
            {
                for (int i = 0; i < n; i++)
                {
                    array[i] = Convert.ToInt32(Console.ReadLine());
                    S += array[i];
                }
                Console.WriteLine("Среднее арифметическое = {0:f2} ", S/n);
                Console.ReadKey();
            }
        }
    }
}
