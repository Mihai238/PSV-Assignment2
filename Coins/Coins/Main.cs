using System;

namespace Coins
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine (Puzzle(new int[] {9, 5, 5}, 3));
		}

		private const int INF = 2000000017;
		// Consider the coin values given in the 'coins' array.
		// You can use the same coin value multiple times.
		// If there is no combination of coins for
		// the required sum, return -1.
		public static int Puzzle(int[] coins, int S) {

			int[] dp = new int[S + 1]; // minimum number of coins to reach the sum S
			for (int i = 0; i <= S; i++)
				dp [i] = INF;

			for (int i = 0; i < coins.Length; i++)
				if (coins[i] <= S) dp [coins [i]] = 1; // initialize dp for one coin

			for (int i = 0; i < S; i++) {
				int sum = dp[i];
				if (sum != INF) {
					foreach (int coin in coins) {
						if (i + coin <= S && dp[i+coin] > dp[i] + 1)
							dp[i+coin] = dp[i] + 1;
					}
				}
			}

			return dp[S] < INF ? dp[S] : -1;
		}
	}
}
