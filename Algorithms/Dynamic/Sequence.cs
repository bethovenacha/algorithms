using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Dynamic
{
    public class Sequence
    {
        /*
         * Find the longest common subsequence
         * ***************************************
         * 
         * To get the subsequence make a string and concatenate the letters if they are the same 
         * 
         *  Sequence sq = new Sequence();

            string f = "stone";
            string s = "longest";

            int res = sq.LongestCommonSubsequence(f, s);

            Console.WriteLine(res.ToString());
            Console.ReadLine();
         * 
         * 
         * *************************************8
         
            */
        public int LongestCommonSubsequence(string first, string second) {

            char[] f = first.ToCharArray();
            char[] s = second.ToCharArray();

            int[,] result = new int[s.Length+1 , f.Length+1];

            for (int row = 0; row <= s.Length  ; row++) { 
                for (int column = 0; column <= f.Length  ; column++) {
                    if (row == 0 || column == 0)
                    {
                        result[row, column] = 0;
                    }
                    else if (s[row-1] == f[column-1])
                    {
                        result[row, column] = 1 + result[row - 1, column - 1]; // gets the value from diagonal and add 1
                    }
                    else {
                        result[row, column] = Math.Max(result[row-1,column],result[row,column-1]);//gets the maximum value from previous row or column
                    }
                }
            }
            
            return result[s.Length ,f.Length];
        }

        
    }
}
