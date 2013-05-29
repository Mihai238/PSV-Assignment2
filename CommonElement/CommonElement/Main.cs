using System;

namespace CommonElement
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine (Puzzle(
				new int[] {3},
				new int[] {1, 2},
				new int[] {2}
				));
		}

		// Smallest common element to 3 SORTED arrays
		public static int Puzzle(int[] a, int [] b, int [] c) {

			int i = 0; int j = 0; int k = 0;
			while (true) {
				if (a[i] == b[j] && b[j] == c[k]) {
					return a[i];
				}

				try {
				while (a[i] < b[j]) i++;
				while (b[j] < c[k]) j++;
				while (c[k] < a[i]) k++;
				}
				catch (Exception e) { return -1;}
			}

			return 2000000069;
		}
	}
}
