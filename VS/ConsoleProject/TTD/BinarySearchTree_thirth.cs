using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleProject
{
    public class Node
    {
        public int Value { get; set; }

        public Node Left { get; set; }

        public Node Right { get; set; }

        public Node(int value, Node left, Node right)
        {
            Value = value;
            Left = left;
            Right = right;
        }
    }

    public class BinarySearchTree
    {
        static bool answer = false;
        public static bool Contains(Node root, int value)
        {
            answer = false;
            Contains(root,value,answer);
            return answer;
            //throw new NotImplementedException("Waiting to be implemented.");
        }

        public static void Contains(Node root, int value, bool ans)
        {
            if (answer == true)
            {
                ans = true;
                return; 
            }
            if (root == null)
            {
                return;
            }
            if (root.Value == value)
            {
                answer = true;
                return;
            }
            else if (root.Value > value)
            {
                Contains(root.Left, value, ans);
                return;
            }
            else
            {
                Contains(root.Right, value, ans);
                return;
            }
            return;
            //throw new NotImplementedException("Waiting to be implemented.");
        }
        /*
        public static void Main(string[] args)
        {
            // 15M
            Node n1 = new Node(1, null, null);
            Node n6 = new Node(6, null, null);
            Node n8 = new Node(8, null, null);
            Node n10 = new Node(10, null, null);

            Node n3 = new Node(3, n1, n6);
            Node n9 = new Node(9, n8, n10);

            Node n7 = new Node(7, n3, n9);
            // 2-> 1,3 
            // 1 -> 4,5
            // 3 -> 6,7

            Console.WriteLine(Contains(n7, 10));
            Console.WriteLine(Contains(n7, 5));
            Console.WriteLine(Contains(n7, 8));
        }
        */
    }
}
