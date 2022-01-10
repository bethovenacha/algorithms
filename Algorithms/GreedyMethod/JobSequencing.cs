using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.GreedyMethod
{
    /*
      JobSequencing js = new JobSequencing();
            string[] job = { "Job1", "Job2","Job3","Job4","Job5","Job6","Job7" };
            int[] profit = { 35,30,25,20,15,12,5 };
            int[] deadline = { 3,4,4,2,3,1,2};
            js.getMaxProfit(profit,deadline,job);
     */
    public class JobSequencing
    {
        public int getMaxProfit(int[] profit, int [] deadline, string [] jobs) {

            int[] copyOfProfit = profit;

            int[] res = sortDescending(profit);

            int max = GetMaxDeadline(deadline);

            
            string[] vacanSlot = new string[max];
            //initialize vacant slot to false
            for (int i = 0; i < vacanSlot.Length; i++) {
                vacanSlot[i] = "false";
            }
            int resultProfit = 0;
            //loop through each profit sorted in descending order
            foreach (var p in res) {
                
               int positionOfDeadlineAndJob = GetPositionOfDeadlineAndJob(copyOfProfit, p);//get the position to get the deadline value
                int dl = deadline[positionOfDeadlineAndJob]; //deadline value
                while (dl > 0) {
                    if (vacanSlot[dl - 1] == "false")
                    {
                        vacanSlot[dl - 1] = jobs[positionOfDeadlineAndJob];
                        resultProfit += copyOfProfit[positionOfDeadlineAndJob];
                        break;
                    }
                    dl--;
                }
               
            }

            return resultProfit;
           
        }

        public int[] sortDescending(int[] a) {
            int[] res = a;
            Array.Sort(res);
            Array.Reverse(res);
           
            return res;
        }

        public int GetPositionOfDeadlineAndJob(int [] copy, int sortedValue) {
           
            return Array.IndexOf(copy, sortedValue);

        }

        public int GetMaxDeadline(int[] deadline) {
            int max = 0;
            for (int i = 1; i < deadline.Length; i++) {
                if (deadline[i] > deadline[i - 1] && deadline[i] > max)
                {
                    max = deadline[i];
                }
                else if(deadline[i-1] > deadline[i] && deadline[i-1] > max) {
                    max = deadline[i - 1];
                }
            }
            return max;
        }
            
    }
}
