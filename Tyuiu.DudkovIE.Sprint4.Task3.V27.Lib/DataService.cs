using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.DudkovIE.Sprint4.Task3.V27.Lib
{
    public class DataService : ISprint4Task3V27
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;
            int length = array.Length / rows;

            int count = 0;
            for(int i = 0; i < length; i++)
            {
                for(int j = 0; j < rows; j++)
                {
                    if(array[i, j] % 2 == 0)
                    {
                        count += 1;
                    }
                }
            }
            return count;
        }
    }
}
