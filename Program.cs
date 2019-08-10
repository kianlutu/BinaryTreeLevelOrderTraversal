using System;
using System.Collections.Generic;
using BinaryTreeLevelOrderTraversal.Class;

namespace BinaryTreeLevelOrderTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }


        public static IList<IList<int>> LevelOrder(TreeNode root)
        {
            IList<IList<int>> results = new List<IList<int>>();
            results = Traversal(results,root,0);
            return results;
        }

        public static IList<IList<int>> Traversal(IList<IList<int>> list, TreeNode root, int level)
        {
            if(root == null)
            {
                return list;
            }

            try
            {
                list[level].Add(root.val);
            }
            catch (System.Exception)
            {
                list.Add(new List<int>());
                list[level].Add(root.val);
                throw;
            }
   
            
            list = Traversal(list, root.left, level++);
            list = Traversal(list, root.right, level++);
            
            return list;
        }
    }
}
