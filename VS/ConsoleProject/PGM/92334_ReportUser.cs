using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleProject
{
    public class ReportUser
    {
        public int[] solution(string[] id_list, string[] report, int k)
        {
            int[] answer = new int[] { };
            Dictionary<string, List<string>> dicReport = new Dictionary<string, List<string>>();
            Dictionary<string, int> dicReported = new Dictionary<string, int>();
            Dictionary<string, int> dicMailed = new Dictionary<string, int>();

            foreach (string strUser in id_list)
            {
                dicReport.Add(strUser, new List<string>());
                dicReported.Add(strUser, 0);
                dicMailed.Add(strUser, 0); 
            }

            string[] strReported = null;
            List<string> ListReported = new List<string>() { };

            foreach (var word in report)
            {
                try 
                {
                    strReported = word.Split(' ');

                    /*
                    if (dic.ContainsKey(strReported[1]) == false)
                        dic.Add(strReported[1], new List<string>());
                    */

                    // 자기 자신을 신고하는 경우는 없다. 
                    // 중복 신고가 아닐 경우 +1
                    if (dicReport[strReported[0]].Contains(strReported[1]) != true ) 
                    {
                        // dicReport [Key(내가),Value(신고한 사람 목록)] 
                        // A가 B를 신고했다.
                        dicReport[strReported[0]].Add(strReported[1]);

                        // dicReported [Key(내가),Value(신고당한 횟수)] 
                        // B는 신고당한 횟수가 1 증가한다.
                        dicReported[strReported[1]] += 1;
                        
                    }
                    
                }
                catch (System.ArgumentException e) {
                    continue;
                // 중복 키일경우 catch를 타게 된다
                }
                //System.Console.WriteLine($"<{word}>");
            }
            foreach (string userName in id_list)
            {
                int inTmp = 0;
                //inTmp = dic[userName].Contains(userName) ? dic[userName].Count - 1 : dic[userName].Count;
                //자기가 자기를 신고한 경우는 없다.

                inTmp = dicReported[userName];

                if (inTmp >= k)
                {
                    // 내가 신고 당한 횟수가 기준치 이상이라면? 
                    // dicReport.Contains를 확인하여 나를 신고한 사람 추적
                    // 그 사람이 메일을 받을 횟수를 하나 증가 시킨다

                }

                /*
               try { 
                int inTmp = 0;
                inTmp = dic[userName].Contains(userName) ? dic[userName].Count -1 : dic[userName].Count;  

                if (inTmp >= k)
                {
                    answer = answer.Concat(new int[] { inTmp }).ToArray();
                }
               }
               catch(System.Collections.Generic.KeyNotFoundException e2)
               {
                continue;
               }
                */
                // 자기가 신고가 넘었을 경우 메일이 발송된다고 생각했을 때 짠 코드.
            }
            return answer;

        }



        public static void Main()
        {
            ReportUser RU = new ReportUser();
            int[] answer = new int[] { };

            string[] id_list = new string[] { "muzi", "frodo", "apeach", "neo" };
            string[] report = new string[] { "muzi frodo", "apeach frodo", "frodo neo", "muzi neo", "apeach muzi" };
            answer = RU.solution(id_list, report, 2);
            foreach (int inRow in answer) Console.WriteLine(inRow);

            string[] id_list2 = new string[] { "con", "ryan" };
            string[] report2 = new string[] { "ryan con", "ryan con", "ryan con", "ryan con" };
            answer = RU.solution(id_list2, report2, 3);
            foreach (int inRow in answer) Console.WriteLine(inRow);
            // 이런식으로 안써도 될거같긴한데
        }
    }
}
