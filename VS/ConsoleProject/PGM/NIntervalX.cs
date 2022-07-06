using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleProject
{
    public class NIntervalX
    {
        public long[] solution(int x, int n)
        {
            long[] answer = new long[] { };
            int idx = 0;
            
            answer[idx] = x;
            for (idx=1; idx<n ;idx++)
            {
                answer[idx] = x;
            }


            return answer;
        }

        public static void Main()
        {
            // x는 - 10000000 이상, 10000000, x는 정수
            // 0< N <= 1000, N은 자연수
            String[] s;
            s = Console.ReadLine().Split(' ');
            int a = Int32.Parse(s[0]);
            int b = Int32.Parse(s[1]);

            NIntervalX nIntervalX = new NIntervalX();

            foreach (long ln in nIntervalX.solution(a, b))
            {
                Console.WriteLine("{0}", ln);
            }
        }//추가보정 필요
    }
}
