using System;

namespace VigenereCipher
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine (Puzzle("", "P"));
		}

		// Implement Vigenère cipher (http://en.wikipedia.org/wiki/Vigen%C3%A8re_cipher)
		public static string Puzzle(string message, string key) {
			string ans = "";
			int len = message.Length;
			int keyLen = key.Length;

			for (int i = 0; i < len; i++) {
				ans += (shift (message[i], key[i%keyLen] - 65));
			}

			return ans;
		}

		public static char shift(char c, int shf) {
			c += (char) shf;
			if (c > 90) c -= (char)26;
			return c;
		}
	}
}
