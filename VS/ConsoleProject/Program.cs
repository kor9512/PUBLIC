using System;

namespace ConsoleProject
{
    internal class Program
    {
        int Count = 0;

        void Recursive(int num)
        {
            Count += 1;
            if (num == 0) return;
            else 
            { 
                Recursive(num - 1);
            }
            // https://www.sysnet.pe.kr/2/0/1599 
            // Recurisve 대신 반복문으로 변환
        }
        /*
        static void Main(string[] args)
        {
            Program prg = new Program();
            prg.Recursive(3);

            Console.WriteLine("{0}",prg.Count);
        }
        */

    }
}
