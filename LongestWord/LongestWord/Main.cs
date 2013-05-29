using System;

namespace LongestWord
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine (Puzzle("cacao cu lapte1"));
		}

		// Find the longest word
		// If there are multiple such words, return the first
		public static string Puzzle(string s) {
			string[] splits = s.Split (' ');

			int max = -2000000007;
			string ans = "";
			foreach (string str in splits) {
				if (str.Length > max) { max = str.Length; ans = str; }
			}

			return ans;
		}
	}
}
