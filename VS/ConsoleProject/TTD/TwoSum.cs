using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleProject
{
    class TwoSum
    {

        public static Tuple<int, int> FindTwoSum(IList<int> list, int sum)
        {
            try
            {
                // IList Sort. 
                IEnumerable<int> sortedEnum = list.OrderBy(x => x);
                List<int> sortedList = sortedEnum.ToList();

                //List.Sort또한 사용 가능. 

                int idx = 0;
                int idy = sortedList.Count - 1;

                if (idx == idy)
                {
                    return null;
                }

                while (idx < sortedList.Count - 1)
                {
                    if (sortedList[idx] + sortedList[idy] < sum)
                    {
                        idx++;
                    }
                    else if (sortedList[idx] + sortedList[idy] > sum)
                    {
                        idy--;
                    }
                    else
                    {
                        int inX = 0;
                        int inY = 0;

                        for (int inidx = 0; inidx < list.Count - 1; inidx++)
                        {
                            if (list[inidx] == sortedList[idx])
                            {
                                inX = inidx;
                                break;
                            }
                        }
                        for (int inidy = list.Count - 1; inidy > 0; inidy--)
                        {
                            if (list[inidy] == sortedList[idy])
                            {
                                inY = inidy;
                                break;
                            }
                        }
                        return new Tuple<int, int>(inX, inY);

                    }
                }


                return null;
            }
            catch(System.ArgumentOutOfRangeException e)
            {
                return null;
            }
            //throw new NotImplementedException("Waiting to be implemented.");
        }
        
        public static void Main(string[] args)
        {
            Tuple<int, int> indices = FindTwoSum(new List<int>() { 3, 1, 5, 7, 5, 9 }, 10);
            if (indices != null)
            {
                Console.WriteLine(indices.Item1 + " " + indices.Item2);
            }
        }
        
    }
}
