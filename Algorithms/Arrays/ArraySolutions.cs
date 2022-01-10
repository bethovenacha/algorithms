using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Arrays
{
    public class ArraySolutions
    {
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
