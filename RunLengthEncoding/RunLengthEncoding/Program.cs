using System;

namespace RunLengthEncoding
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine (Puzzle(""));
		}

		// http://en.wikipedia.org/wiki/Run-length_encoding
		public static string Puzzle(string input) {
			String ans = ""; if (input.Length == 0) return ans;

			int cnt = 1;
			for (int i = 1; i < input.Length; i++) {
				if (input [i] == input [i-1]) {
					cnt++;
				} else {
					ans += Convert.ToString (cnt) + Convert.ToString (input[i-1]);
					cnt = 1;
				}
			}
			ans += Convert.ToString (cnt) + Convert.ToString (input[input.Length - 1]);

			return ans;
		}
	}
}
