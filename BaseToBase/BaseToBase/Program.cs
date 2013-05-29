using System;

namespace BaseToBase
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine (Puzzle("008", 10, 36));
		}

		// For example: "101"(2) => "5"(10) and "ZZZ"(36) => "46655"(10)
		public static string Puzzle(string s, int baseA, int baseB) {
			while (s.Length > 1 && s[0] == '0')
				s = s.Substring (1);
			if (s == "0")
				return s;
			string ans = "";

			if (baseB == 10) {
				ans = to10 (s, baseA);
			} else if (baseA == 10) {
				ans = from10 (s, baseB);
			}
			else {
				ans = to10 (s, baseA);
				ans = from10 (ans, baseB);
			}

			return ans;
		}

		public static string to10(string s, int baseA) {
			int len = s.Length;
			int ans = 0;
			for (int i = 0; i < len; i++) {
				ans += charToInt(s[i]) * ((int)Math.Pow (baseA, len-i-1));
			}
			return Convert.ToString (ans);
		}

		public static string from10(string s, int baseB) {
			int len = s.Length;
			string ans = "";

			int val = (int) Double.Parse (s);
			while (val != 0) {
				ans = intToChar(val % baseB) + ans;
				val /= baseB;
			}

			return ans;
		}

		public static char intToChar (int val) {
			if (val < 10)
				return Convert.ToChar (val.ToString());
			return (char) (val - 10 + 65);
		}
		public static int charToInt(char c) {
			if (Char.IsDigit (c))
				return (int)Char.GetNumericValue (c);
			return ((int)c - 'A') + 10;
		}
	}
}
