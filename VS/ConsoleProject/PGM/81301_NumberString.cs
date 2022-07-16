using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleProject
{
    public class NumberString
    {
        public int solution(string s)
        {
            string strAnswer = "hi";
            // 1. string s 를 확인
            // 2. 숫자라면 스트링 빌더에 집어넣고, 아니라면 스위치 케이스 문 비교.
            // 스위치 케이스문에는 one부터 nine까지 존재
            // 값을 확인해서 해당 값을 집어 넣는다 

            return strAnswer;
            
        }
        
        
        public static void Main()
        {
            NumberString nString = new NumberString();
            nString.solution("123");
            nString.solution("2three45sixseven");

        }
        /*
         ex.
        "23four5six7"	234567
        "2three45sixseven"	234567
        "123"	123

        z
        o
        t
        th
        fo
        fi
        si
        se
        ei
        ni

        0	zero
        1	one
        2	two
        3	three
        4	four
        5	five
        6	six
        7	seven
        8	eight
        9	nine

         */

    }
}
