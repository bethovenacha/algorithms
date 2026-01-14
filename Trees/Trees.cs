using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Trees
{
    public static class Trees
    {
        /// <summary>
        /// Finds the closes value in the node in a tree from a given target
        /// </summary>
        /// <param name="tree"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int FindClosestValueInBst(BST tree, int target)
        {
            return FindClosestValueInBstHelper(tree, target, tree.value);
        }

        private static int FindClosestValueInBstHelper(BST tree, int target, int closest)
        {
            if (tree == null)
            {
                return closest;
            }

            if (Math.Abs(target - closest) > Math.Abs(target - tree.value))
            {
                closest = tree.value;
            }

            if (target < tree.value)
            {
                return FindClosestValueInBstHelper(tree.left, target, closest);
            }
            else if (target > tree.value)
            {
                return FindClosestValueInBstHelper(tree.right, target, closest);
            }
            else
            {
                return tree.value;
            }
        }

        /// <summary>
        /// SUMS UP EVERY VALUE OF NODES IN THE TREE
        /// </summary>
        /// <param name="root"></param>
        /// <returns>Returns a list of integers</returns>
        public static List<int> BranchSums(BST root)
        {
            List<int> sums = new List<int>();
            CalculateBranchSums(root, 0, sums);
            return sums;
        }

        private static void CalculateBranchSums(
            BST node,
            int runningSum,
            List<int> sums)
        {
            if (node == null)
            {
                return;
            }

            int newRunningSum = runningSum + node.value;

            if (node.left == null && node.right == null)
            {
                sums.Add(newRunningSum);
                return;
            }

            CalculateBranchSums(node.left, newRunningSum, sums);
            CalculateBranchSums(node.right, newRunningSum, sums);
        }
    }
}
