using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Basic {
	class LearnUnsafe {
		/// <summary>
		/// 使用unsafe时必须在项目属性里配置“允许不安全代码”，这会在编译时csc /unsafe prog1.cs加上选项
		/// </summary>
		/// <param name="args"></param>
		static unsafe void Main(string[] args) {
			int var = 20;
			int* p = &var;
			Console.WriteLine("Address of {0} is {1}", p->ToString(), (int)p);
			Console.ReadKey();
		}
	}
}
