using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleProject
{
    public class HidingPhoneNumber
    {
        public string solution(string phone_number)
        {
            string answer = string.Concat(Enumerable.Repeat("*", phone_number.Length - 4));
            answer += phone_number.Substring(phone_number.Length - 4, 4);
            return answer;
        }
        /*
        public static void Main()
        {
            //StringBuilder sb = new StringBuilder("");
            string question = "010-000-1234";
            //string answer = question.Substring(-4, 4);
            //string answer = "*" * (question.Length - 4);
            string answer = string.Concat(Enumerable.Repeat("*", question.Length - 4));
            answer += question.Substring(question.Length-4, 4);
        }
        */
    }
}
