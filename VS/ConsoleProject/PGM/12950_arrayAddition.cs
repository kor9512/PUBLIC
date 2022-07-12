using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleProject
{
    public class arrayAddition
    {
        public class Solution
        {
            public int[,] solution(int[,] arr1, int[,] arr2)
            {
                int arr1Row = arr1.GetLength(0);
                int arr1Col = arr1.GetLength(1);
                //Array.GetLength(차원의 수).
                //Dimension_0(Row),Dimension_1(Col)

                int[,] answer = new int[arr1Row, arr1Col];

                for (int idx = 0; idx < arr1Row; idx++)
                {
                    for (int idy = 0; idy < arr1Col; idy++)
                    {
                        answer[idx, idy] = arr1[idx, idy] + arr2[idx, idy];
                    }
                }
                return answer;
            }
        }
        /*
        public static void Main()
        {
            
        }
        */
    }
}
