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
        /// <summary>
        /// This function sums up every depth of the node starting from the root node until the leaf node.
        /// </summary>
        /// <param name="root"></param>
        /// <param name="depth"></param>
        /// <returns></returns>
        public static int NodeDepths(BST root, int depth = 0)
        {
            if (root == null) return 0;
            return depth + NodeDepths(root.left, depth + 1) + NodeDepths(root.right, depth + 1);
        }
        /// <summary>
        /// EVALUATE EXPRESSION TREE
        /// </summary>
        /// <param name="tree"></param>
        /// <returns></returns>
        public static int EvaluateExpressionTree(BST tree)
        {

            if (tree.value >= 0)
            {
                return tree.value;
            }

            var leftValue = EvaluateExpressionTree(tree.left);
            var rightValue = EvaluateExpressionTree(tree.right);

            if (tree.value == -1)
            {
                return leftValue + rightValue;
            }
            if (tree.value == -2)
            {
                return leftValue - rightValue;
            }
            if (tree.value == -3)
            {
                return leftValue / rightValue;
            }

            return leftValue * rightValue;
        }
        /// <summary>
        /// DepthFirstSearch
        /// </summary>
        /// <param name="node"></param>
        /// <param name="array"></param>
        /// <returns></returns>
        public static List<string> DepthFirstSearch(Node node, List<string> array)
        {
            if (node == null) return array;

            array.Add(node.name);

            foreach (var child in node.children)
            {
                DepthFirstSearch(child, array);
            }

            return array;
        }

    }
}
