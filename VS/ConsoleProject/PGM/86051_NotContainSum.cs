using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleProject
{
    public class NotContainSum
    {
        public int solution(int[] numbers)
        {
            // 1<= numbers의 길이 <= 9
            // 0<= numbers의 원소값 <= 9
            // 없는 수를 더한다
            int answer = 0;
            foreach(int inrow in numbers)
            {
                answer += inrow;
            }
            // 1 + 2 + 3 ... +9 = 45
            answer = 45 - answer; 
            return answer;
        }
        /*
        public static void Main()
        {
            int[] num = new int[] {0,1,2,3,4,5,6,7,8};
            NotContainSum sol = new NotContainSum();
            sol.solution(num);
            return;
        }
        */
    }
}
