using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleProject
{
    public class SearchTree_Node
    {
        public int Value { get; set; }
        
        public SearchTree_Node Left { get; set; }

        public SearchTree_Node Right { get; set; }
        public SearchTree_Node Before { get; set; }
        public bool Visit { get; set; }

        public SearchTree_Node(int value, SearchTree_Node left, SearchTree_Node right)
        {
            Visit = false;
            Value = value;
            Left = left;
            Right = right;
        }
    }

    /*
    public class SearchTree
    {

        public static bool Contains(SearchTree_Node root, int value)
        {
            HashSet<SearchTree_Node> NodeList = new HashSet<SearchTree_Node>() { };
        
            while (true)
            { 
                if(root != null)
                {
                    root.Visit = true;
                    NodeList.Add(root);

                    if (root.Value == value)
                    {   
                        foreach(SearchTree_Node node in NodeList)node.Visit = false;
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
                    foreach (SearchTree_Node node in NodeList) node.Visit = false;
                    return false;
                    throw new IndexOutOfRangeException("Null Root");
                }
             }

            foreach (SearchTree_Node node in NodeList) node.Visit = false;
            return false;
            //throw new NotImplementedException("Waiting to be implemented.");
        }
        public static void Main(string[] args)
        {
            // 15M
            SearchTree_Node n4 = new SearchTree_Node(4, null, null);
            SearchTree_Node n5 = new SearchTree_Node(5, null, null);
            SearchTree_Node n6 = new SearchTree_Node(6, null, null);
            SearchTree_Node n7 = new SearchTree_Node(7, null, null);

            SearchTree_Node n1 = new SearchTree_Node(1, n4, n5);
            SearchTree_Node n3 = new SearchTree_Node(3, n6, n7);

            SearchTree_Node n2 = new SearchTree_Node(2, n1, n3);
            // 2-> 1,3 
            // 1 -> 4,5
            // 3 -> 6,7

            Console.WriteLine(Contains(n2, 5));
            Console.WriteLine(Contains(n2, 4));
            Console.WriteLine(Contains(n2, 8));
        }
        

    }*/
}
