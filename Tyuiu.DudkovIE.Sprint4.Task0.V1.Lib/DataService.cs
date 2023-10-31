﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.DudkovIE.Sprint4.Task0.V1.Lib
{
    public class DataService : ISprint4Task0V1
    {
        public int GetSumEvenArrEl(int[] array)
        {
            int result = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] % 2 == 0)
                {
                    result += array[i];
                }
            }
            return result;
        }
    }
}
