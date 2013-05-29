using System;

namespace CatDog
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine (Puzzle ("cacao docatg"));
		}

		// #dog =? #cat
		public static bool Puzzle(string input) {
			int cntC = 0;
			int cntD = 0;

			for (int i = 2; i < input.Length; i++) {
				if (input[i-2] == 'c' && input[i-1] == 'a' && input[i] == 't') cntC++;
				if (input[i-2] == 'd' && input[i-1] == 'o' && input[i] == 'g') cntD++;
			}

			return cntC == cntD;
		}
	}
}
