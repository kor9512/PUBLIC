using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleProject
{
    public class KNumber
    {  
        public int[] solution(int[] array, int[,] commands)
        {
            int[] answer = new int[] { };
            int i, j, k = 0;
            for (int idx = 0; idx < commands.GetLength(0) ; idx++)
            {
                i = commands[idx,0];
                j = commands[idx,1];
                k = commands[idx,2];

                //int[] tmpArray = new int[] { };
                List<int> tmpArray = new List<int>() { };
                for (int idy = i - 1; idy < j; idy++)
                {
                    //tmpArray = tmpArray.Concat(new int[] { array[idy] }).ToArray();
                    // int[]로 선언할 경우 따로 Add 지원 X
                    tmpArray.Add(array[idy]); // List<int>여야 가능.
                }
                
                tmpArray.Sort();
                // int[] 에는 지원 X
                //answer[idx] = (tmpArray[k -1]);
                answer = answer.Concat(new int[] { tmpArray[k-1] }).ToArray();
                //answer.Add(tmpArray[k - 1]);
            }
            // k. 정지 당하는 신고의 횟수. 
            return answer;
         }
            
        /*
        public static void Main()
        {
            KNumber KN = new KNumber();
            int[] answer = new int[]{};
            int[] array = new int[] { 1, 5, 2, 6, 3, 7, 4 };
            int[,] commands = new int[,] { { 2, 5, 3 }, { 4, 4, 1 }, { 1,7,3} };

            answer = KN.solution(array,commands);
            foreach (int inRow in answer) Console.WriteLine(inRow);
        }
        */
    }
}
