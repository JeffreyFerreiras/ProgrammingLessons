using System;
using System.Collections;
using System.Collections.Generic;
//using System.Collections.Generic;

namespace DataStructures
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //var tree = new Trees.BinaryTree<int>();
            //for(int i = 1; i < 20; i++)
            //{
            //    tree.Add(i + 1);
            //}
            //;

            //tree.DisplayPreOrder(tree.Root);
            //Console.WriteLine();
            //tree.DisplayInOrder(tree.Root);
            //Console.WriteLine();
            //tree.DisplayPostOrder(tree.Root);
            //Console.WriteLine();
            //tree.DisplayLevelOrder();

            //Console.ReadLine();

            var queue = new Queue<int>();

            queue.Enqueue(5);
            queue.Enqueue(4);
            queue.Enqueue(1);

            int test = queue.Dequeue();

            var stackRank = recursive(false, 0);
        }

        static int recursive(bool stop, int rank)
        {
            if (rank > 15)
            {
                stop=true;
            }
             
            if (stop)
                return rank;

            return recursive(stop, rank+1);
        }
    }
}