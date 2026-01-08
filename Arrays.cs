using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms
{
    public static class Arrays
    {
        /// <summary>
        /// inputs an array of integers and the targetSum
        /// outputs integers that sums up the target
        /// </summary>
        /// <param name="array"></param>
        /// <param name="targetSum"></param>
        /// <returns></returns>
        public static int[] TwoNumberSum(int[] array, int targetSum)
        {
            int[] result = new int[2];
            HashSet<int> h = new HashSet<int>();

            foreach (var num in array)
            {
                int dif = targetSum - num;
                if (h.Contains(dif))
                {
                    return new int[] { dif, num };
                }
                h.Add(num);
            }

            return Array.Empty<int>();
        }

        public static int[] SortedSquaredArray(int[] array)
        {
            int[] result = new int[array.Length];
            if (array == null || array.Length == 0) return new int[] { };
            int left = 0;
            int right = array.Length - 1;
            int pos = array.Length - 1;

            while (left <= right)
            {
                int leftSquare = array[left] * array[left];
                int rightSquare = array[right] * array[right];
                if (Math.Abs(array[left]) > Math.Abs(array[right]))
                {
                    result[pos] = leftSquare;
                    left++;
                }
                else
                {
                    result[pos] = rightSquare;
                    right--;
                }
                pos--;
            }

            return result;
        }
    }
}
