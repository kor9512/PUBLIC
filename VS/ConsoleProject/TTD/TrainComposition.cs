using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleProject
{
    public class Train
    {
        public int Value { get; set; }

        public Train Left { get; set; }

        public Train Right { get; set; }

        public Train(int value, Train left, Train right)
        {
            Value = value;
            Left = left;
            Right = right;
        }
    }

    public class TrainComposition
    {
        int inTmp = 0;
        LinkedList<int> Linkint =new LinkedList<int> ();
        public void AttachWagonFromLeft(int wagonId)
        {
            Linkint.AddFirst(wagonId);
            //throw new NotImplementedException("Waiting to be implemented.");
        }

        public void AttachWagonFromRight(int wagonId)
        {
            Linkint.AddLast(wagonId);
            //throw new NotImplementedException("Waiting to be implemented.");
        }

        public int DetachWagonFromLeft()
        {
            if (Linkint.Count == 0)
            { 
                return 0; 
            }
            else 
            {
               inTmp = 0;
               inTmp = Linkint.First.Value;
               Linkint.RemoveFirst();
               return inTmp;
            }
            //throw new NotImplementedException("Waiting to be implemented.");
        }

        public int DetachWagonFromRight()
        {
            if (Linkint.Count == 0)
            {
                return 0;
            }
            else
            {
                inTmp = 0;
                inTmp = Linkint.Last.Value;
                Linkint.RemoveLast();
                return inTmp;
            }
            //throw new NotImplementedException("Waiting to be implemented.");
        }

        public static void Main(string[] args)
        {
            TrainComposition train = new TrainComposition();
            train.AttachWagonFromLeft(7);
            train.AttachWagonFromLeft(13);
            Console.WriteLine(train.DetachWagonFromRight()); // 7 
            Console.WriteLine(train.DetachWagonFromLeft()); // 13
        }
    }
}
