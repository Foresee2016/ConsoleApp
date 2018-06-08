using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Algo.Binary {
    class RussianDollEnvelopes {
        static void Main(string[] args) {
            //int[][] envelops = { new int[]{ 5, 4 }, new int[] { 6, 4 }, new int[] { 6, 7 }, new int[] { 2, 3 } };
            int[,] envelops = { { 5, 4 }, { 6, 4 }, { 6, 7 }, { 2, 3 } };
            MaxEnvelopes(envelops);
        }
        /// <summary>
        /// 排序，先按行，后按列。之后总选小的
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public static int MaxEnvelopes(int[,] envelopes) {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < envelopes.Length; i++) {
                if (dict.ContainsKey(envelopes[i,0])) {
                    if (envelopes[i, 1] > dict[i]) {
                        dict[i] = envelopes[i, 1];
                    }
                }
            }
            
            return 0;
        }
    }
}
