// Based on https://leetcode.com/problems/coin-change/

namespace LeetChallenges
{
    using System;
    class Solution
    {
        // Finds the minimum number of coins required to reach 'amount'.
        // It may be that not all the denominatoins in the set are required.
        // It is assumed that there is an infinite amount of coins of each denomination and the coins are ordered small to large.
        static int CoinChange(int[] coins, int amount)
        {
            int numCoins = 0;
            if (coins.Length == 0)
            {
                return -1;
            }
                if (amount == 0 && coins.Length > 0)
            {
                return 1;
            }
            for (int i = coins.Length - 1; i > -1; i--)
            {
                // Is the amount remaining > the current denomination?
                if (coins[i] > amount)
                {
                    continue;
                }
                // Does the amount remaining divide exactly into the current denomination?
                if (amount % coins[i] == 0)
                {
                    return numCoins + (amount / coins[i]);
                }
                if (amount % coins[i] != 0)
                {
                    numCoins += (int)(amount / coins[i]);
                    amount = amount % coins[i];
                }
            }
            return -1;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Minimum coins required is " + CoinChange(new int [] { 1, 2, 5 }, 11)); // Should be 3
            Console.WriteLine("Minimum coins required is " + CoinChange(new int[] { 2 }, 3)); // Should be -1
            Console.WriteLine("Minimum coins required is " + CoinChange(new int[] { 1 }, 0)); // Should be 0
            Console.WriteLine("Minimum coins required is " + CoinChange(new int[] { 1 }, 1)); // Should be 1
            Console.WriteLine("Minimum coins required is " + CoinChange(new int[] { 1 }, 2)); // Should be 2
        }
    }
}
