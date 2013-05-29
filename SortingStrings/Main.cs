using System;
using System.Collections;

namespace SortingStrings
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Puzzle (new string[]{"baaa", "aaba", "cbcc"});
		}

		//Sort the array of strings, where each string is four characters long
		public static string[] Puzzle(string[] s) {
			int len = s.Length;


			for (int i = 0; i < 4; i++) {

				ArrayList[] lists = new ArrayList[26];

				//Split
				for (int ind = 0; ind < len; ind++) {
					char c = Convert.ToChar(s[ind][3 - i]);
					int ascii = (int)c - 97;
					if (lists[ascii] == null) lists[ascii] = new ArrayList();
					lists[ascii].Add(s[ind]); 
				}

				s = new string[len];
				int indix = 0;
				//Collect
				for (int j = 0; j < 26; j++) {
					ArrayList curList = lists[j];
					if (curList != null) {
						foreach (String str in curList) {
							s[indix++] = str;
						}
					}
				}
			}

			//foreach (String str in s) Console.Write(str + " ");
			return s;
		}
	}
}
