using System;

namespace Median
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.Write (Puzzle(new double[] {}));
		}

		public static double Puzzle(double[] a) {
			int len = a.Length;
			Array.Sort (a);
			return ((a [len / 2] + a [(len - 1) / 2]) / 2);
		}

		private static int getOrder(int[] A, int left, int right, int order) {
			int p = partition (A, left, right);
			//Console.WriteLine (left + " " +right);
			//for (int i = left; i <= right; i++)
				//Console.Write (A [i] + " ");
			//Console.WriteLine ();
			if (p == order)
				return A[p];
			if (p > order)
				return getOrder (A, left, p - 1, order);
			if (p < order)
				return getOrder (A, p + 1, right, order);
			return -1;
		}

		private static Random random = new Random ();

		// get the position of the pivot after partition routine
		public static int partition(int[] A, int left, int right) {
			int pivPoz = random.Next (left, right + 1);
			//pivPoz = 1;
			int piv = A [pivPoz];

			int aux = A [right]; // take the pivot to the right
			A[right] = A[pivPoz];
			A[pivPoz] = aux;

			int i = left - 1; int j = right;
			while (i < j) {
				do {
					i++;
				} while (A[i] <= piv && i < j);
				if (i >= j) break;
				do {
					j--;
				} while (A[j] > piv && i < j);

				aux = A[i]; A[i] = A[j]; A[j] = aux;
			}


			aux = A [i];
			A [i] = A [right];
			A [right] = aux; // place the pivot where it belongs

			return i;
		}
	}
}
