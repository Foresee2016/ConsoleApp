using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Basic {
    class NullableValue {
        static void Main(string[] args) {
            int? num1 = null;
            int? num2 = 45;
            double? num3 = new double?();
            double? num4 = Math.PI;
            Console.WriteLine("值：{0}, {1}, {2}, {3}", num1, num2, num3, num4);
            bool? boolValue = null;
            Console.WriteLine("可为空值的bool：{0}", boolValue);

            int merge1 = num1 ?? 5;
            int val = 10;
            int merge2 = num2 ?? val;
            Console.WriteLine("合并可空的值，{0}，{1}",merge1,merge2);
            double merge3 = num3 ?? 5.34;
            double dval = 20.30;
            double merge4 = num4 ?? dval;
            Console.WriteLine("合并double，{0}, {1}", merge3, merge4);
            Console.Read();
        }
    }
}
