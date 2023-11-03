using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.DudkovIE.Sprint4.Task3.V27.Lib;
namespace Tyuiu.DudkovIE.Sprint4.Task3.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[,] { { 4, 3, 5, 5, 3 },

                                        { 6, 7, 4, 4, 3 },

                                        { 3, 3, 7, 3, 6 },

                                        { 3, 4, 3, 7, 7 },

                                        { 3, 5, 6, 3, 6 }
            };
            int rows = array.GetUpperBound(0) + 1;
            int length = array.Length / rows;
            DataService ds = new DataService();


            Console.Title = "Спринт #4 | Выполнил: Дудков И.Е | СМАРТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерный массив                 *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Выполнил: Дудков И.Е  | СМАРТб-23-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный массив заполенный статическими значениями, подсчитать кол-во четных элементов массива*");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            
            Console.WriteLine("Ваш массив");
            for (int i = 0; i < length; i++)
            {
                for(int j = 0; j < rows; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(array);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
