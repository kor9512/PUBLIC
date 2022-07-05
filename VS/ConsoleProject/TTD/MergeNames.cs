using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleProject
{
    public class MergeNames
    {
        public static string[] UniqueNames(string[] names1, string[] names2)
        {
            List<string> list = new List<string>();
            foreach (string name in names1)list.Add(name);
            foreach (string name2 in names2) list.Add(name2);

            list = list.Distinct().ToList();

            String[] strarray = (String[])list.ToArray();
            
            return strarray;
            //        throw new NotImplementedException();
        }

        /*public static void Main(string[] args)
        {
            string[] names1 = new string[] { "Ava", "Emma", "Olivia" };
            string[] names2 = new string[] { "Olivia", "Sophia", "Emma" };
            Console.WriteLine(string.Join(", ", MergeNames.UniqueNames(names1, names2))); // should print Ava, Emma, Olivia, Sophia
        }
        */
    }
}
