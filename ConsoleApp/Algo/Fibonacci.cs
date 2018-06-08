using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Algo
{
    /**
     * 计算斐波那契数列
     */
    class Fibonacci
    {
        static void Main(string[] args)
        {
            int n = 40;
            long ts = (long)DateTime.Now.Subtract(DateTime.Parse("1970-1-1")).TotalMilliseconds;
            int res = Fibonacci.Fn(n);
            System.Threading.Thread.Sleep(100);
            long ts2 = (long)DateTime.Now.Subtract(DateTime.Parse("1970-1-1")).TotalMilliseconds;
            Console.WriteLine("Fibonacci of " + n + " = " + res + " time: " + (ts2 - ts));
            Console.Read();
        }
        /**
         * 递归方法
         * 效率非常低
         */
        public static int Fn(int n)
        {
            if (n == 1 || n == 2)
            {
                return 1;
            }
            return Fn(n - 1) + Fn(n - 2);
        }
        /**
         * 循环递推的方法，效率好很多
         */
        public static long Fn2(int n)
        {
            long a = 1;
            long b = 1;
            long c = 1;

            for (int i = 3; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            return c;
        }
    }
}
