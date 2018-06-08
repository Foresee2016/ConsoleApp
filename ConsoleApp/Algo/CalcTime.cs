using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Algo
{
    class CalcTime
    {
        static void Main(string[] args)
        {
            long ts = (long)DateTime.Now.Subtract(DateTime.Parse("1970-1-1")).TotalMilliseconds;
            System.Threading.Thread.Sleep(100);
            long ts2 = (long)DateTime.Now.Subtract(DateTime.Parse("1970-1-1")).TotalMilliseconds;
            Console.WriteLine("time: " + (ts2 - ts));
            Console.Read();
        }
    }
}
