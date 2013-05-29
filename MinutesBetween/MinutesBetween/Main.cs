using System;

namespace MinutesBetween
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine (Puzzle("23:20", "23:20"));
		}

		// If 't1' is after (smaller than) 't2', assume 't1' is day before than 't2'
		public static int Puzzle(string t1, string t2) {
			int h1 = Convert.ToInt16 (t1.Substring (0, 2));
			int h2 = Convert.ToInt16 (t2.Substring (0, 2));
			int m1 = Convert.ToInt16 (t1.Substring (3, 2));
			int m2 = Convert.ToInt16 (t2.Substring (3, 2));

			int minT1 = h1 * 60 + m1;
			int minT2 = h2 * 60 + m2;

			return (minT2 >= minT1) ? (minT2 - minT1) : ((1440 - minT1) + minT2);
		}
	}
}
