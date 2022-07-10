using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleProject
{
    class TwoSum
    {
        // 값이 아닌 idx를 반환하는 것이다!
        //Tuple<int, int> tuAnswer = null;
        //List<Tuple<int, int>> TuList;
        //List<Tuple<int, int>> TuList = new List<Tuple<int, int>>(null);
        //List<Tuple<int, int>> TuList = new List<Tuple<int, int>>();

        //TuList.Add( new Tuple<int, int>(list[idx], list[idy]) );
        //Tuple<int, int> tuAnswer = new Tuple<int, int>(list[idx], list[idy]);
        //TuList.Add(new Tuple<int, int>(list[idx], list[idy]));
        //TuList.Add(new Tuple<int, int>(idx, idy));
        //return TuList[0];// new Tuple<int, int>(idx, idy);   

        //(System.NullReferenceException e) { return null; }
        //(System.ArgumentOutOfRangeException e2){ return null;}

        public static Tuple<int, int> FindTwoSum(IList<int> list, int sum)
        {

            for (int idx=0; idx < list.Count; idx++)
            {
                for (int idy = idx + 1; idy < list.Count; idy++)
                {
                    if (list[idx] + list[idy] == sum)
                    {
                        return new Tuple<int, int>(idx, idy);
                    }
                }
            }
                return null;
            
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
