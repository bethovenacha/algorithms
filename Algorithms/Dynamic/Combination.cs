using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Dynamic
{
    public class Combination
    {
        /*
         int[] coins = {1,2,5 };
            int amount = 12;
            Combination c = new Combination();
           int result =  c.Change(coins, amount);

            Console.WriteLine(result.ToString());
            Console.ReadLine();
         
         */
        public int Change(int[] coins, int amount) {
            int[] combinations = new int[amount + 1];

            combinations[0] = 1;
            for (int x = 0; x < coins.Length; x++) {
                for (int i=1; i < combinations.Length;i++) {
                    if (i >= coins[x]) {
                        combinations[i] += combinations[i - coins[x]];
                    }
                }
            }

            return combinations[amount];
        }
    }
}
