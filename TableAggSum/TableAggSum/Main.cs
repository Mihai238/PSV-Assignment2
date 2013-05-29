using System;
using System.Collections.Generic;

namespace TableAggSum
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int[][] ans = Puzzle(new int[][] {
				new int[] {0, 0},
				new int[] {0, 0},
				new int[] {0, 0},
				new int[] {1, 5},
				new int[] {0, 0},
				new int[] {1, 5},
				new int[] {400, 5},
			});
			for (int i = 0; i < ans.Length; i++) {
				Console.WriteLine(ans[i][0] + " " + ans[i][1]);
			}
		}

		// The input is a Nx2 array where each row consists of:
		// ID (in the interval [0, 400]) and a value for this ID.
		// Each ID might occur multiple times and your task is to
		// sum values for the each ID.
		// You should return each ID which occurred in the input data
		// and the associated aggregated sum.
		// IDs should appear in the ascending order.
		public static int[][] Puzzle(int[][] a) {
			int count = 0;
			Dictionary<int, int> hash = new Dictionary<int, int> ();
			for (int i = 0; i < a.Length; i++) {
				if (!hash.ContainsKey(a[i][0])) {hash.Add(a[i][0], 0); count++; }
				hash[a[i][0]] = hash[a[i][0]] + a[i][1];
			}
			int[][] ans = new int[count][];
			count = 0;
			foreach (KeyValuePair<int, int> pair in hash) {
				ans[count] = new int[2];
				ans[count][0] = pair.Key;
				ans[count][1] = pair.Value;
				count++;
			}

			return ans;
		}
	}
}
