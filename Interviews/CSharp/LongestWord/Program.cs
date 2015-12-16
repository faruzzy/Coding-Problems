using System;
using System.Collections.Generic;

namespace LongestWord
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var longest = LongestWord ("I am the life, the spirit and the truth. Who seems me, sees the father");
			Console.WriteLine (longest[0]);
		}

		private static string[] LongestWord(string sentence)
		{
			string[] words = sentence.Split (' ');
			var longest = new List<string> ();

			foreach (string word in words) {
				if (longest.IndexOf (word) == -1) {
					if (longest.Count > 0 && longest [0].Length < word.Length) {
						longest.Clear ();
						longest.Add (word);
					} else if (longest [0].Length == word.Length || longest.Count == 0) {
						longest.Add (word);
					}
				} else {
					longest.Add (word);
				}
			}

			return longest.ToArray ();
		}
	}
}
