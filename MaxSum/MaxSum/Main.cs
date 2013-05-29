using System;

namespace MaxSum
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ( Puzzle(new int[] {-1, 1, 3, -100, 105}));
		}

		// Subarray of length 0 has sum 0
		public static int Puzzle(int[] a) {
			int len = a.Length;
			const int INF = 2000000017;

			int sum = -INF; int ans = -INF;
			for (int i = 0; i < len; i++) {
				if (0 > sum) {
					sum = a[i];
				} else sum += a[i];
				ans = Math.Max(sum, ans);
			}

			return ans == INF ? 0 : ans;
		}
	}
}
