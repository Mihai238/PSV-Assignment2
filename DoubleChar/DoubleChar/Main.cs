using System;

namespace DoubleChar
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine (Puzzle("a  a"));
		}

		public static string Puzzle(string s) {
			string ans = "";

			foreach (char c in s) {
				ans += new string(c, 1) + new string(c, 1);
			}

			return ans;
		}
	}
}
