using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Arrays
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
        /// <summary>
        /// This function returns the squares of each item in an array in a sorted order
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
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

        /// <summary>
        /// This function returns true if an array is a subsequence of another array
        /// </summary>
        /// <param name="array"></param>
        /// <param name="sequence"></param>
        /// <returns></returns>
        public static bool IsValidSubsequence(List<int> array, List<int> sequence)
        {
            int sIndex = 0;
            foreach (var item in array)
            {
                if (sIndex < sequence.Count && item == sequence[sIndex])
                {
                    sIndex++;
                }

            }
            return sIndex == sequence.Count;
        }
        /// <summary>
        /// This function determines to see the winner team based on the results array
        /// </summary>
        /// <param name="competitions"></param>
        /// <param name="results"></param>
        /// <returns></returns>
        public static string TournamentWinner(
    List<List<string>> competitions, List<int> results
  )
        {
            Dictionary<string, int> d = new Dictionary<string, int>();
            int rowIndex = 0;
            int bestScore = 0;
            string bestTeam = "";
            foreach (var result in results)
            {
                List<string> match = competitions[rowIndex];
                string winner = result == 1 ? match[0] : match[1];
                if (!d.ContainsKey(winner)) d[winner] = 0;
                d[winner] += 3;
                if (d[winner] > bestScore) { 
                    bestScore = d[winner];
                    bestTeam = winner;
                }
                rowIndex++;
            }
           
            return bestTeam;
        }
        /// <summary>
        /// Returns NonConstructible change from a sorted array of coins
        /// </summary>
        /// <param name="coins"></param>
        /// <returns></returns>
        public static int NonConstructibleChange(int[] coins)
        {
            Array.Sort(coins);
            int change = 0;
            foreach (var coin in coins)
            {
                int current = change + 1;
                if (coin > current) return current;
                change += coin;
            }
            return change + 1;
        }
        /// <summary>
        /// This function returns a transposed matrix
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        public static int[,] TransposeMatrix(int[,] matrix)
        {
            int row = matrix.GetLength(0);
            int col = matrix.GetLength(1);
            int[,] transposed = new int[col, row];
            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    transposed[i, j] = matrix[j, i];
                }
            }
            return transposed;
        }
        /*
         public static int[][] TransposeMatrix(int[][] matrix)
        {
            int rows = matrix.Length;
            int cols = matrix[0].Length;

            int[][] transposed = new int[cols][];

            for (int col = 0; col < cols; col++)
            {
                transposed[col] = new int[rows];
                for (int row = 0; row < rows; row++)
                {
                    transposed[col][row] = matrix[row][col];
                }
            }

            return transposed;
        }

         */
    }
}
