using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Algo.DP {
	class MinimumAsciiDeleteTwoString {
		public static int LEFT = 1;
		public static int UP = 2;
		public static int OBLIQUE = 3;
		public static int BOTH = 4;

		static void Main(string[] args) {
			MinimumDeleteSum("elte", "leet");
			Console.WriteLine();
			Console.ReadKey();
		}
		public static int MinimumDeleteSum(string s1, string s2) {
			string res = MaxSubArray(s1, s2);
			return 0;
		}
		// 找出两个字符串的最大公共子串，列表，因为可能不止一个
		public static string MaxSubArray(string A, string B) {
			int m = A.Length, n = B.Length;
			int[,] c = new int[m + 1, n + 1];
			int[,] p = new int[m, n];
			for (int i = 0; i < m + 1; i++) {
				c[i, 0] = 0;
			}
			for (int i = 1; i < n; i++) {
				c[0, i] = 0;
			}
			for (int i = 1; i < m + 1; i++) {
				for (int j = 1; j < n + 1; j++) {
					if (A.ElementAt(i - 1) == B.ElementAt(j - 1)) {
						c[i, j] = c[i - 1, j - 1] + 1;
						p[i - 1, j - 1] = OBLIQUE;
					} else {
						if (c[i - 1, j] == c[i, j - 1]) {
							c[i, j] = c[i - 1, j];
							p[i - 1, j - 1] = BOTH;
						} else if (c[i - 1, j] > c[i, j - 1]) {
							c[i, j] = c[i - 1, j];
							p[i - 1, j - 1] = UP;
						} else {
							c[i, j] = c[i, j - 1];
							p[i - 1, j - 1] = LEFT;
						}
					}
				}
			}
			//for (int i = 0; i < m+1; i++) {
			//	for (int j = 0; j < n+1; j++) {
			//		Console.Write(c[i,j]+",");
			//	}
			//	Console.WriteLine();
			//}
			// 根据p生成结果。遇到两条路，都选。
			List<string> strings = new List<string>();

			return "";
		}
		public static void GenerateResult(string[] A, string[] B, int[,] p, List<string> strings) {
			int m = p.Rank, n = p.GetUpperBound(0) + 1;
			string str = "";
			GenerateResult(A, B, p, m, n, (string)str.Clone(), strings);
		}
		// 递归生成结果，终点处字符串取反，保存在list里
		public static void GenerateResult(string[] A, string[] B, int[,] p, int m, int n, string str, List<string> strings) {
			if (m < 0) {
				str += B[n];
				//str = str.Reverse();
			}
			if (p[m, n] == BOTH) {
				GenerateResult(A, B, p, m, n, str, strings);
				GenerateResult(A, B, p, m, n, str, strings);
			}
			if (p[m, n] == OBLIQUE) {
				GenerateResult(A, B, p, m, n, str + A[m], strings);
			}
			if (p[m, n] == LEFT) {
				GenerateResult(A, B, p, m, n, str, strings);
			}
			if (p[m, n] == UP) {
				GenerateResult(A, B, p, m, n, str, strings);
			}
		}
	}
}
