using System;
using System.Collections.Generic;
using System.Collections;

namespace Intersection
{
	class MainClass
	{
		public static void Main (string[] args)
		{
		int[] ans = Puzzle (
			new int[] { 0, 0},
			new int[] { 0, 0 ,0},
			new int[] {  0});
		foreach (int i in ans)
				Console.WriteLine(i);
		}

		// Return the intersection of three arrays.
		public static int[] Puzzle(int[] a, int [] b, int [] c) {
			ArrayList list = new ArrayList();

			Dictionary<int, int> hash = new Dictionary<int, int> ();
			foreach (int i in a)
				if (!hash.ContainsKey(i)) hash.Add (i, 1);
			foreach (int i in b)
				if (hash.ContainsKey(i))
					hash [i]++;
			foreach (int i in c)
				if (hash.ContainsKey (i))
					hash [i]++;
			foreach (int i in hash.Keys)
				if (hash [i] >= 3)
					list.Add (i);

			return (int[]) list.ToArray (typeof(int));
		}
	}
}
