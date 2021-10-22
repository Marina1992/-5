using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Сформировать одномерный массив из 15 элементов, которые выбираются случайным образом из диапазона [0; 50]. 
             * Определить сумму максимального и минимального элементов массива.  */

            int[] array = new int[15];
            Random random = new Random();

            for (int i = 0; i < 15; i++)
            {
                array[i] = random.Next(0, 50);
                Console.Write("{0}, ", array[i]);
            }

            Console.WriteLine();

            Console.WriteLine("наибольший элемент : {0}", array.Max());


            Console.WriteLine("наименьший элемент : {0}", array.Min());
            Console.WriteLine("Сумма наибольшего и наименьшего элементов : {0}", (array.Min() + array.Max()));

            // способ 2
            int max = array[0];
            foreach (int a in array)
            {
                if (a > max)
                    max = a;
            }
            Console.WriteLine("наибольший элемент cпособ 2 : {0}", max);

            int min = array[0];
            foreach (int a in array)
            {
                if (a < min)
                    min = a;
            }
            Console.WriteLine("наименьший  элемент cпособ 2 : {0}", min);
            Console.WriteLine("Сумма наибольшего и наименьшего элементов : {0}", (max + min));

            Console.ReadKey();


        }
    }
}
