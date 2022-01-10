using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Arrays
{
    public class ArraySolutions
    {

        // Find the longest span with same sum
        /*
         int[] arr1 = { 0,1,0,1,1,1,1};
            int[] arr2 = { 1,1,1,1,1,0,1};

            ArraySolutions s = new ArraySolutions();
           int output = s.longestcommonsum(arr1, arr2, arr1.Length);
            Console.Write("Longest common sum : " + output);
            Console.ReadLine();
         */
        public int longestcommonsum(int [] arr1,int[] arr2,int n) {
            int maxlen = 0;
           
            for (int i = 0; i < n; i++) {
                int sum1 = 0; int sum2 = 0;
                for (int j = i; j < n; j++)
                {
                    sum1 += arr1 [j];
                    sum2 += arr2 [j];
                    if (sum1 == sum2) {
                        int len = j - i + 1;
                        if (len > maxlen)
                        {
                            maxlen = len;
                        }
                    }
                }
            }

            return maxlen;
        
        }
        /*
          int[] num = { 1,2,4,5,6};

            ArraySolutions s = new ArraySolutions();
          int result =  s.FindMissingNumber(num, 5);
            Console.Write("Result: " + result);
            Console.ReadLine();
         */
        public int FindMissingNumber(int[] numbers, int n) {
            int missing = int.MaxValue;
            missing = (n + 1) * (n + 2) / 2;
            foreach (var number in numbers) {
                missing -= number;
            }
            return missing;
        }
        /*
         int[] num = { 2,5,3,5,4,4,2,3 };
            int n = num.Length;
            int x = 3;
            int y = 2;

            ArraySolutions s = new ArraySolutions();
            int result = s.FindMinDistance(num, n, x, y);
            Console.Write("Minimum Distance: " + result);
            Console.ReadLine();
         */
        public int FindMinDistance(int[] num,int n, int x,int y) {
            ///
            // METHOD 1
            //int mindistance = int.MaxValue;
            //for (int i = 0; i < n; i++) {
            //    for (int j = i + 1; j < n; j++) {
            //        if (x == num[i] && y == num[j] ||
            //            y == num[i] && x == num[j] &&
            //            mindistance > Math.Abs(i - j)
            //            )
            //        {
            //            mindistance = Math.Abs(i - j);

            //        }
            //    }
            //}
            ///
            ///METHOD 2
            int i = 0;
            int mindistance = int.MaxValue;
            int previous = 0;
            for (i = 0; i < n; i++) {
                if (num[i] == x || num[i] == y) {
                    previous = i;
                    break;
                }
            }

            for (; i < n; i++) {
                if (num[i] == x || num[i] == y) {
                    if (num[i] != num[previous] && (i - previous) < mindistance)
                    {
                        mindistance = i - previous;
                        previous = i;
                    }
                    else {
                        previous = i;
                    }
                }
            }
            return mindistance;
        }

        //Write a program to print all the leaders in the array
        // An element is leader if it's greater than all the elements to its right side
        // exampe:  {16,17,4,3,5,2} leaders are 17,5,2
        public int[] FindLeaders(int[] num, int size) {
            int[] leaders = new int[size];
            //METHOD 1
            //for (int i = 0; i < size; i++) {
            //    int j=0;
            //    for (; j+1 < size; j++) {
            //        if (num[i] <= num[j]) {
            //            break;
            //        }
            //    }
            //    if (j == size) {
            //        leaders[j] = num[i];
            //    }
            //}
            int max_from_right = num[size-1];
            leaders[size - 1] = max_from_right;
            for (int i = size - 2; i >=0 ; i--) {
                if (max_from_right < num[i]) {
                    max_from_right = num[i];
                    leaders[i] = max_from_right;
                }
            }
            return leaders;
        }
    
    
    }
}
