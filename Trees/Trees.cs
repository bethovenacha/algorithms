using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Trees
{
    public static class Trees
    {
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
    }
}
