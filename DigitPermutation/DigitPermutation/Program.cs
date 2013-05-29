using System;

namespace DigitPermutation
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int[] ints = new int[10];
			ints[0] = 1;
			ints[1] = 1;
			ints[2] = 1;
			ints[3] = 1;
			ints[4] = 9;
			ints[5] = 2;
			ints[6] = 1;
			ints[7] = 1;
			ints[8] = 1;
			ints[9] = 1;
			int[] ans = Puzzle (new int[]{2, 3, 3});
			ans = Puzzle(ints);
			foreach (int i in ans)
				Console.Write (i + " ");
		}

		// a[0] is most significant position
		// see http://en.wikipedia.org/wiki/Permutation#Generation_in_lexicographic_order
		// for what is meant by 'next permutation'
		public static int [] Puzzle(int[] a) {
			int len = a.Length;
			int first = -1;
			for (int i = 0; i < len - 1; i++) {
				if (a[i] < a[i+1]) first = i;
			}
			if (first == -1)return a; // we have already the last permutation
			int last = -1;
			for (int i = first + 1; i < len; i++) {
				if (a [i] > a [first])
					last = i;
			}

			//Reverse the order after first
			swap (a, first, last);
			first++;
			for (int i = first; i <= (first + (len-1)) / 2; i++) {
				swap (a, i, (len-1) - (i - first));
			}

			return a;
		}

		public static void swap(int[]a, int i, int j) {
			int aux = a [i]; a [i] = a[j]; a [j] = aux;
		}
	}
}
