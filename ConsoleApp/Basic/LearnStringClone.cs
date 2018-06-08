using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Basic {
	class LearnStringClone {
		static void Main(string[] args) {
			string src = "abcd";
			Console.WriteLine(src);
			string res = ChangeStr(src);
			Console.WriteLine("src: "+src);
			Console.WriteLine("res: "+res);
			Console.ReadKey();
		}
		public static string ChangeStr(string str) {
			Console.WriteLine("beforeChange:"+str);
			str += "qwer";
			Console.WriteLine("afterChange: "+str);
			return str;
		}
	}
}
