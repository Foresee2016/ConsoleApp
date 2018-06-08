using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Algo.DP {
	class PalindromicSubsequence {
		// 不会做
		static void Main(string[] args) {
			int res = CountPalindromicSubsequences("bccb");
			Console.WriteLine(res);
			Console.ReadKey();
		}
		public static int CountPalindromicSubsequences(string S) {
			int n = S.Length;
			Hashtable table = new Hashtable();
			for (int len = 1; len <= n; len++) {
				for (int i = 0; i < n - len + 1; i++) {
					string str = S.Substring(i, len);
					if (IsPalindrome(str)) {
						table[str] = len;
					}
				}
			}
			return table.Count;
		}
		public static bool IsPalindrome(string str) {
			int end = str.Length - 1;
			int left = end / 2, right = (end + 1) / 2;
			while (left >= 0) {
				if (str.ElementAt(left) != str.ElementAt(right)) {
					return false;
				}
				left--;
				right++;
			}
			return true;
		}
	}
}
