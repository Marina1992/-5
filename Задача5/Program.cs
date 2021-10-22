using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Обязательная задача*. Запросить у пользователя целочисленное значение N. Сформировать двумерный массив размера NxN следующего вида:
            1 0 1 0 1
            0 1 0 1 0
            1 0 1 0 1
            0 1 0 1 0
            1 0 1 0 1
            */


            Console.WriteLine("Введите кол-во элементов массива  N");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[n, n];



            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)


                {
                    Console.WriteLine(" Введите значения массива Y: " + i + "X: " + j);
                    array[i, j] = Convert.ToInt32(Console.ReadLine());

                }
            }

            for (int y = 0; y < n; y++)
            {

                for (int x = 0; x < n; x++)
                {
                    Console.Write(array[y, x] + "\t");
                }
                Console.WriteLine();
            }




            Console.ReadKey();


        }
    }
}
