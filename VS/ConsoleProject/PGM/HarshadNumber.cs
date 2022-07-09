using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleProject
{
    public class HarshadNumber
    {
        public bool solution(int x)
        {
            string stSol = x.ToString();
            int inTmp = 0;
            bool answer = false;


            for (int idx = 0; idx < stSol.Length; idx++)
            {
                // ASCII 코드 말고 그대로 변환되는 방법은 없을까
                inTmp += stSol[idx] - 48;
                //inTmp += (int)stSol[idx] -48;
                //inTmp += int.Parse(stSol[idx]); // 안됨.
                                                //char -> System.ReadOnlySpan<char>로 변경 불가 
                inTmp += Convert.ToInt32(stSol[idx]) -48;//아스키로 넘어온다
            }

            if (x % inTmp == 0)
            {
                answer =  true;
            }
 
            return answer;
        }
        /*
        public static void Main()
        {
            
            int x = 18;
            bool answer = false;
            HarshadNumber hn = new HarshadNumber();
            answer = hn.solution(x);
            
         }
        */

    }

}
