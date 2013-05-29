using System;

namespace ReverseList
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int[] list = new int[] { -1 };
			PrintList('O', 0, list);
			int[] ans =  (Puzzle (0, list));
			PrintList('O', 2, ans);

		}

		// A variable 'p' and an array 's' describe a "linked list".
		// 0 <= p <= (s.Length-1) points to the first element of a linked list.
		// Every element of s (s[i]), points to the next element in the list.
		// The last element of the list (not necessarily of the array) points to -1 (s[last]=-1).
		//
		// Your task is to reverse the links in the list: If there was a link from a to b, the new list should contain a link from b to a
		// and the first element from the original list should point to -1 in the new list
		// (so, if s[i]=x then ns[x]=i and ns[p]=-1, where 's' is the original list and 'ns' is the reversed list).
		//
		// Hint: You can visualize lists (the original and the new one) by clicking 'Ask Pex', clicking on a row in the resulting Input/Output pairs, and finally clicking on 'Visualize graph')

		public static int[] Puzzle(int p, int[] s) {
			int[] ns = new int[s.Length];
			if (s.Length == 1)
				return s;

			ns [p] = -1;
			int last = p;
			p = s [p];
			while (s[p] != -1) {
				ns [p] = last;
				last = p;
				p = s [p];
			}
			ns [p] = last;

			return ns;
		}

		public static void PrintList(Char c, int p, int[] s) {
			while (s[p] != -1) {
				Console.Write("{0}{1} -> {0}{2} ", c, p, s[p]);
				p = s[p];
			}
			Console.WriteLine("{0}{1} -> {0}X", c, p);
		}
	}
}
