using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Сформировать одномерный массив из 7 элементов. 
             * Заполнить массив числами, вводимыми с клавиатуры, определить среднее арифметическое элементов. */

            float [] array = new float[7];
            float S = 0;
            for (int i = 0; i < 7; i++)
            {
                Console.Write("Введите число массива:");
                array[i] = Convert.ToUInt32(Console.ReadLine());
                S += array[i];
                Console.Write("Введено число : {0}\n ", array[i]);
            }
            Console.WriteLine();
            Console.WriteLine( " Среднее арифметическое 7 чисел :{0:f2}",(S/7));
            Console.ReadKey();

        }
    }
}
