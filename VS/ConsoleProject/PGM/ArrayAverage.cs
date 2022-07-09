using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleProject
{
    public class ArrayAverage
    {
        public double solution(int[] arr)
        {
            double answer = 0;

            foreach (double i in arr)
            {
                answer += i;
            }
            answer = answer / arr.Length;

            return answer;
        }
        /*
        public static void Main()
        {
        }
        */
    }
}
