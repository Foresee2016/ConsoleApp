using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Basic {
    class LearnArrays {
        static void Main(string[] args) {
            //int[,] a = new int[5, 2] { { 0, 0 }, { 1, 2 }, { 2, 4 }, { 3, 6 }, { 4, 8 } };
            int[,] a = { { 0, 0 }, { 1, 2 }, { 2, 4 }, { 3, 6 }, { 4, 8 } };

            int i, j;

            /* 输出数组中每个元素的值 */
            for (i = 0; i < 5; i++) {
                for (j = 0; j < 2; j++) {
                    Console.WriteLine("a[{0},{1}] = {2}", i, j, a[i, j]);
                }
            }
            Console.ReadKey();
        }
    }
}
