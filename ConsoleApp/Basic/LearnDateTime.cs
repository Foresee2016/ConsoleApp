using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Basic {
    class LearnDateTime {
        static void Main(string[] args) {
            DateTime time = new DateTime(2018, 1, 19, 20, 12, 12);
            string str = String.Format("At: {0:t} on {0:D}", time);
            Console.WriteLine(str);
            Console.Read();
        }
    }
}
