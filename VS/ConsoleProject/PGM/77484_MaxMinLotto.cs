using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleProject
{
    public class MaxMinLotto
    {
        public int[] solution(int[] lottos, int[] win_nums)
        {
            int[] answer = new int[] {0,0};
            List<int> ListLottos = lottos.ToList();
            List<int> ListWin_nums = win_nums.ToList();
            int inanswer = 0;
            ListLottos.Sort();
            ListWin_nums.Sort();

            int zeroidx = 0;
            zeroidx = ListLottos.LastIndexOf(0) + 1;

            int idx = 0;
            int idy = 0;
            try { 
            for(idx = zeroidx ; idx < ListLottos.Count- zeroidx || idy < ListLottos.Count; )
            {
                if (ListLottos[idx] == ListWin_nums[idy])
                {
                    inanswer += 1;
                    idx++;
                }
                else if (ListLottos[idx] < ListWin_nums[idy])
                {
                    idx++;
                }
                else if (ListLottos[idx] > ListWin_nums[idy])
                {
                    idy++;
                }
            }
            }
            catch (System.ArgumentOutOfRangeException e)
            {
                // Need Fix
                //NOP
            }
            switch (inanswer) { 
                case 0:
                    answer[0] = 1;
                    answer[1] = 6;
                    return answer;
                case 1:
                    answer[1] = 6;
                    break;
                case 2:
                    answer[1] = 5;
                    break;
                case 3:
                    answer[1] = 4;
                    break;
                case 4:
                    answer[1] = 3;
                    break;
                case 5:
                    answer[1] = 2;
                    break;
                case 6:
                    answer[1] = 1;
                    break;
                default:
                    break;
            }
            answer[0] = answer[1] - zeroidx;

            
            return answer;
        }
        /*
        public static void Main()
        {
            //Fail

            int[] lottos = new int[] { 44, 1, 0, 0, 31, 25 };
            int[] win_nums = new int[] { 31, 10, 45, 1, 6, 19 };
            MaxMinLotto lt = new MaxMinLotto();
            
            // {44, 1, 0, 0, 31, 25}	{31, 10, 45, 1, 6, 19}	[3, 5]
            // {0, 0, 0, 0, 0, 0}	{38, 19, 20, 40, 15, 25}	[1, 6]
            // {45, 4, 35, 20, 3, 9}	{20, 9, 3, 45, 4, 35}	[1, 1]
             
            lt.solution(lottos, win_nums);
            Console.WriteLine("End");
        }
        */       
    }
}
