﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS_27_01_2023_jap
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };

                for (int i = 0; i < numbers.GetLength(0); i++)
                {
                    for (int j = 0; j < numbers.GetLength(1); j++)
                    {
                        Console.WriteLine(numbers[i, j]);
                    }
                }

            }
        }
    }
}
