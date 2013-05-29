using System;
using System.Collections;

namespace Order3
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int[] a = new int[] {3, 2, 1, 3, 2, 1, 3, 2, 1, 1, 2, 3};
			a = Puzzle (a);
			foreach (int i in a)
				Console.Write (i + " ");
		}

		// Use only the provided "Swap" function to change the position of elements in the array
		public static int[] Puzzle(int[] a) {
			int len = a.Length;

			Queue ones  = new Queue ();
			Queue twos  = new Queue ();

			// find the positions
			for (int i = 0; i < len; i++) {
				if (a[i] == 1) ones.Enqueue(i);
			}
			//sort the array
			for (int i = 0; i < len; i++) {
				if (a[i] >= 1 && ones.Count != 0) 
					Swap(a, i, (int) ones.Dequeue());;
			}

			// find the positions
			for (int i = 0; i < len; i++) {
				if (a[i] == 2) twos.Enqueue(i);
			}
			//sort the array
			for (int i = 0; i < len; i++) {
				if (a[i] >= 2 && twos.Count != 0) 
					Swap(a, i, (int) twos.Dequeue());
			}

			return a;
		}
		
		public static void Swap(int[] A, int i, int j) {
			int t = A[i];
			A[i] = A[j];
			A[j] = t;
		}
	}
}
