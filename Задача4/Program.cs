using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Сформировать одномерный массив из 20 случайных чисел в диапазоне [-50;50]. 
             *  Определить количество   нечетных положительных элементов, стоящих на четных местах.  */
            int[] array = new int[20];
            Random random = new Random();
            int p = 0;
            Console.WriteLine(" Все числа одномерного массива: ");
            for (int i = 0; i < 20; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.Write("{0}" + " ", array[i]);
            }

            Console.WriteLine();
            Console.WriteLine(" Все числа на четных местах из массива: ");
            for (int k = 1; k < 20; k += 2)
            {
                Console.Write("{0}" + " ", array[k]);

                if ((array[k] > 0) & (array[k] % 2 == 1))
                {
                    p += 1;

                }
            }

            Console.WriteLine("\n Положительные  нечетные элементы : {0}  ", p);

            Console.ReadKey();

        }
    }
}
