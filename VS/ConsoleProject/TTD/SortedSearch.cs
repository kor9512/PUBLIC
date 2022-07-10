using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleProject
{
    public class SortedSearch
    {
        public static int CountNumbers(int[] sortedArray, int lessThan)
        {
            int low = 0;
            int high = sortedArray.Length - 1;
            int mid = -1;
            
            // high가 low보다 작아진다면 찾으려는 데이터가 데이터 집합에 없다.
            while (low <= high)
            {
                // 중앙값은 low와 high를 더한 값을 2로 나누면 된다.
                mid = (low + high) / 2;
                // 만약 찾으려는 값이 중앙값보다 작다면 high를 mid - 1로 둔다.
                if (sortedArray[mid] > lessThan) high = mid - 1;
                // 만약 찾으려는 값이 중앙값보다 크다면 low를 mid + 1로 둔다.
                else if (sortedArray[mid] < lessThan) low = mid + 1;
                // 중앙값과 찾으려는 값이 일치하면 mid를 반환한다.
                else return mid;
            }
            // 데이터를 찾지 못하면 -1를 반환한다.
            //return -1;
            return low;
            
            /*
            int inAnswer = 0;

            foreach(int i in sortedArray)
            {
                if (i >= lessThan)
                {
                    break;
                }
                else
                {
                    inAnswer++;
                }
            }
            return inAnswer;
            //throw new NotImplementedException("Waiting to be implemented.");
            */
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(SortedSearch.CountNumbers(new int[] { 1 }, 4));
            Console.WriteLine(SortedSearch.CountNumbers(new int[] { 1, 3, 5, 7 }, 4));
            Console.WriteLine(SortedSearch.CountNumbers(new int[] { 1, 3, 5, 7, 9 }, 5));
        }
    }
}
