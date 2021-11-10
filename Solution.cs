// Based on https://leetcode.com/problems/coin-change/

namespace LeetChallenges
{
    using System;
    class Solution
    {
        // Finds the minimum number of coins required to reach 'amount'.
        // It may be that not all the denominatoins in the set are required.
        // It is assumed that there is an infinite amount of coins of each denomination and the coins are ordered small to large.
    static int CoinChange(int[] coins, int V)
    {
        int moneyRemaining = V;
        int coinsUsed = 0;
        if(moneyRemaining == 0)
        {
            return 0;
        }
        for(int i = coins.Length - 1; i > -1; i--)
        {
            if(coins[i] > moneyRemaining)
            {
                continue;
            }
            if(moneyRemaining % coins[i] == 0)
            {
                coinsUsed += (moneyRemaining / coins[i]);
                return coinsUsed;
            }
            else
            {
                coinsUsed += (moneyRemaining / coins[i]);
                moneyRemaining = (moneyRemaining % coins[i]);
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
