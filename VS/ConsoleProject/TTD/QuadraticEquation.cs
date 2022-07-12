using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleProject
{
    public class QuadraticEquation
    {
        public static Tuple<double, double> FindRoots(double a, double b, double c)
        {
            double dnx = 0.0;
            double dny = 0.0;

            dnx = (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c))/(2*a);
            dny = (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c))/(2*a);

            Tuple<double, double> answer = new Tuple<double, double>(dnx,dny);
            return answer;
            //throw new NotImplementedException("Waiting to be implemented.");
        }
        /*
        public static void Main(string[] args)
        {
            
            Tuple<double, double> roots = QuadraticEquation.FindRoots(2, 10, 8);
            Console.WriteLine("Roots: " + roots.Item1 + ", " + roots.Item2);
            
        }
        */
    }
}
