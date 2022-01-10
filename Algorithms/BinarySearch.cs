using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class BinarySearch
    {
        //=================================================
        //PROBLEM: FIND THE POSITION OF THE TARGET ELEMENT
        //IF FOUND RETURN THE POSITION
        //IF NOT RETURN -1
        //================================================

        //=================================================
        //SOLUTION :
        /*  int[] A = { 1,2,3,4,5,6,8 };

          BinarySearch b = new BinarySearch();

         int result = b.search(A, 7);

          if (result == -1)
          {
              Console.WriteLine("The target is not found");
              Console.ReadLine();
          }
          else {
              Console.WriteLine("The target is in position : " + result);
              Console.ReadLine();
          }
          */
        public int search(int[] A, int target) {
            int R = A.Length - 1;
            int L = 0;
            while (L <= R) {
                int mid = L + ((R - L) / 2);
                if(A[mid] == target){
                    //return A[mid];
                    return mid; //mid is the position of the searched target
                }
                if (A[mid] < target)
                {
                    L = mid + 1;
                }
                else {
                    R = mid - 1;
                }
            }

            return -1;
        }
        //PROBLEM ========================================
        // FIND THE FIRST VALUE in THE ARRAY WHICH IS >= X
        //================================================
        /*
           int x = 4;

           int[] A = { 2,3, 4, 5};

           BinarySearch b = new BinarySearch();

           int result = b.searchLowerBound(A, x);

           if (result != 0) {
               Console.WriteLine("The answer is: " + result);
               Console.ReadLine();
           }
           else
           {
               Console.WriteLine("The answer cannot be found.");
               Console.WriteLine();
           }
           */
        public int searchLowerBound(int[] A, int num) {
            int ans = 0;

            int R = A.Length - 1;
            int L = 0;
            while (L <= R)
            {
                int mid = L + ((R - L) / 2);
                if (A[mid] >= num)
                {
                    //return A[mid];
                    ans = A[mid]; //if the value of the mid satisfies the condition, store it as possible answer and keep looking
                    R = mid - 1;
                }
                else {
                    L = mid + 1;
                }
               
            }
            return ans;
        }
    }
}
