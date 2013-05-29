using System;

namespace Seq235
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.Write(Puzzle (9));
		}

		// Consider all numbers divisible by no other primes than 2, 3 and 5. Return nth such number.
		public static int Puzzle(int n) {
			int len = 100;
			bool[] chk = new bool[len];

			for (int i = 1; i < len; i++) {
				chk[i] = false;
			}
			for (int i = 7; i < len; i++) {
				if (!chk[i] && !(i%2==0 || i%3==0 || i%5==0)) {
					for (int j = i; j < len; j += i) {
						chk[j] = true;
					}
				}
			}

			int ind = 0;
			for (int i = 1; i < len; i++) {
				if (chk[i] == false) ind++;
				if (ind == n) return i;
			}

			return 0;
		}
	}
}
