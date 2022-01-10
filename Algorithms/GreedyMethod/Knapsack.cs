using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.GreedyMethod
{
    //Greedy Method is a programming approach optimization problems such as finding the minimum and maximum result.
    // dynamic programming and branch and bound is also used in optimization
    public class Knapsack
    {
        //=====================================================
        // A container or a knapsack has a capacity weight of 15. 
        // Each objects has a corresponding profit and weight.
        // What are the objects to be included?
        // How much weight can you put in the bag?
        // What is the greates profit can you get?
        // Constraint is that the weight to be included would not exceed the capacity.
        //======================================================
        /*
        int[] ourObjects = { 1,2,3,4,5,6,7 };
        int[] profit = { 10, 5, 15,7,6,18,3 };
        int[] weight = { 2,3,5,7,1,4,1 };

        int capacity = 15;
        Knapsack k = new Knapsack();
       int result = k.maximumProfit(ourObjects, profit, weight,capacity);

        Console.WriteLine("The maximum profit is: " + result);
        Console.ReadLine();
        */
        public int maximumProfit(int[] obj, int[] profit, int[] weight, int capacity) {
            int[] profitOverWeight = new int[obj.Length];
            //store the values of profit/weight
            for (int i = 0; i < obj.Length; i++)
            {
                profitOverWeight[i] = (profit[i] / weight[i]);
            }
            //sort the array of profit over weight and select the biggest value until capacity is full
            Array.Sort(profitOverWeight); //array is sorted in descending value
            

            //maximum profit of the result is profitOverWeight * profit 
            int maximumProfit = 0;
            int position = 0;
            for (int j = profitOverWeight.Length - 1; j >= 0; j--)
            {
                for (int k = 0; k <= profitOverWeight.Length - 1; k++)
                {
                    if (profitOverWeight[j] == (profit[k] / weight[k]))
                    {
                        position = k; //determine the position of profit and weight 
                    }
                }
                if (capacity >= weight[position])
                {
                    capacity -= weight[position];
                    maximumProfit += profit[position];
                }//
                else
                { // if portion of the object is required include this statement
                    int portionProfit = profit[position] / (weight[position] / capacity);
                    maximumProfit += (portionProfit);
                }
            }
           
            return maximumProfit;
        }
    }
}
