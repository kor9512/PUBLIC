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
            string strAnswer = "";
            StringBuilder sb = new StringBuilder();
            // 1. string s 를 확인
            // 2. 숫자라면 스트링 빌더에 집어넣고, 아니라면 스위치 케이스 문 비교.
            // 스위치 케이스문에는 one부터 nine까지 존재
            // 값을 확인해서 해당 값을 집어 넣는다 
            for(int idx = 0; s.Length > idx  ;idx ++)
            {
                switch (s[idx])
                { // z, o , t, t, f, f, s, s, e, n 
                    case 'z': // zero
                        sb.Append(0);
                        idx += 3; 
                        break;
                    case 'o': // one
                            sb.Append(1);
                            idx += 2; 
                            break;
                    case 't': // two, three
                        if (s[idx+1] =='w')
                        {
                            sb.Append(2);
                            idx += 2;
                        }
                        else
                        {
                            sb.Append(3);
                            idx += 4;
                        }
                        break;
                    case 'f': // four, five
                        if (s[idx+1] =='o')
                        {
                            sb.Append(4);
                        }
                        else
                        {
                            sb.Append(5);
                        }
                        idx += 3;
                        break;
                    case 's': // six, seven
                        if (s[idx + 1] == 'i')
                        {
                            sb.Append(6);
                            idx += 2;
                        }
                        else
                        {
                            sb.Append(7);
                            idx += 4;
                        }
                        break;
                    case 'e': // eight
                        sb.Append(8);
                        idx += 4;
                        break;
                    case 'n': // nine
                        sb.Append(9);
                        idx += 3;
                        break;
                    default:
                        sb.Append(s[idx]);
                        break;

                    
                }
            }

            strAnswer = sb.ToString();
            return Convert.ToInt32(strAnswer);
            
        }
        
        /*
        public static void Main()
        {
            NumberString nString = new NumberString();
            nString.solution("123");
            nString.solution("2three45sixseven");

        }
        */
        /*
         ex.
        "23four5six7"	234567
        "2three45sixseven"	234567
        "123"	123
        */
    }
}
