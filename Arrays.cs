using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms
{
    public static class Arrays
    {
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
    }
}
