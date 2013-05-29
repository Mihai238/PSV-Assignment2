using System;

namespace LongestEqual
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine (Puzzle(new int[] {1, 1}));
		}

		public static int Puzzle(int[] a) {
			if (a.Length == 0) return 0;
			int ans = 1;

			int cur = 1;
			for (int i = 1; i < a.Length; i++) {
				ans = Math.Max(ans, cur);
				if (a[i-1] == a[i]) cur++; 
				else cur = 1;
			}
			ans = Math.Max(ans, cur);

			return ans;
		}
	}
}
