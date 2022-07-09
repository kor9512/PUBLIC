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
        public Node Before { get; set; }
        public bool Visit { get; set; }

        public Node(int value, Node left, Node right)
        {
            Visit = false;
            Value = value;
            Left = left;
            Right = right;
        }
    }

    public class BinarySearchTree
    {

        
        public static bool Contains(Node root, int value)
        {
            HashSet<Node> NodeList = new HashSet<Node>() { };
        
            while (true)
            { 
                if(root != null)
                {
                    root.Visit = true;
                    NodeList.Add(root);

                    if (root.Value == value)
                    {   
                        foreach(Node node in NodeList)node.Visit = false;
                        return true; }

                    if (!(root.Visit != true && root.Left.Visit != true && root.Right.Visit != true))
                    {
                        if(root.Left !=null && root.Left.Visit != true)
                        {
                            root.Left.Before = root;
                            root = root.Left;
 
                        }
                        else if (root.Right != null && root.Right.Visit != true)
                        {   
                            root.Right.Before=root;
                            root = root.Right;
                            //  root.Visit = root.Right.Visit;
                        }
                        else
                        {
                            root = root.Before;
                            //root.Visit = root.Before.Visit;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    foreach (Node node in NodeList) node.Visit = false;
                    return false;
                    throw new IndexOutOfRangeException("Null Root");
                }
             }

            foreach (Node node in NodeList) node.Visit = false;
            return false;
            //throw new NotImplementedException("Waiting to be implemented.");
        }
        
        public static void Main(string[] args)
        {
            // 15M
            Node n4 = new Node(4, null, null);
            Node n5 = new Node(5, null, null);
            Node n6 = new Node(6, null, null);
            Node n7 = new Node(7, null, null);

            Node n1 = new Node(1, n4, n5);
            Node n3 = new Node(3, n6, n7);

            Node n2 = new Node(2, n1, n3);
            // 2-> 1,3 
            // 1 -> 4,5
            // 3 -> 6,7

            Console.WriteLine(Contains(n2, 5));
            Console.WriteLine(Contains(n2, 4));
            Console.WriteLine(Contains(n2, 8));
        }
        
    }
}
