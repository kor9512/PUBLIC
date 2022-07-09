using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleProject
{
    public class Node_second
    {
        public int Value { get; set; }

        public Node_second Left { get; set; }

        public Node_second Right { get; set; }

        public Node_second(int value, Node_second left, Node_second right)
        {
            Value = value;
            Left = left;
            Right = right;
        }
    }

    public class BinarySearchTree_second
    {
        static bool answer = false;
        public static bool Contains(Node_second root, int value)
        {
            answer = false;
            Contains(root, value, false); 
            return answer;
            
            //throw new NotImplementedException("Waiting to be implemented.");
        }
        public static void Contains(Node_second root, int value, bool ans)
        {
            if (ans == true) return ;

            if (root.Value == value)
            {
                ans = true;
                answer = true;
                return;
            }
            else if (root == null)
            {
                ans = false;
                return;
            }
            if (root.Left != null) Contains(root.Left, value, ans);

            if (root.Right != null) Contains(root.Right, value, ans);

            ans = false;
            return;
        }

        public static void Main(string[] args)
        {
            // 15M
            Node_second n4 = new Node_second(4, null, null);
            Node_second n5 = new Node_second(5, null, null);
            Node_second n6 = new Node_second(6, null, null);
            Node_second n7 = new Node_second(7, null, null);

            Node_second n1 = new Node_second(1, n4, n5);
            Node_second n3 = new Node_second(3, n6, n7);

            Node_second n2 = new Node_second(2, n1, n3);
            // 2-> 1,3 
            // 1 -> 4,5
            // 3 -> 6,7

            Console.WriteLine(Contains(n2, 5));
            Console.WriteLine(Contains(n2, 4));
            Console.WriteLine(Contains(n2, 8));
        }
    }
}
