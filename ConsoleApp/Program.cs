using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.Algo;

namespace ConsoleApp {
    class Program {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args) {
            long ts3 = (long)DateTime.Now.Subtract(DateTime.Parse("1970-1-1")).TotalMilliseconds;
            int n2 = 60;
            long res2 = Fibonacci.Fn2(n2);
            for (int i = 0; i < 10000000; i++) {
                res2 = Fibonacci.Fn2(n2);
            }
            long ts4 = (long)DateTime.Now.Subtract(DateTime.Parse("1970-1-1")).TotalMilliseconds;
            Console.WriteLine("Fibonacci of " + n2 + " = " + res2 + " time: " + (ts4 - ts3));
            Console.Read();
        }

    }
}
