using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Basic {
	class GenerateGuid {
		static void Main(string[] args) {
			Guid guid = Guid.NewGuid();
			string str = guid.ToString();
			Console.WriteLine(str);
			Console.WriteLine(str.Length);
			Console.WriteLine(Guid.NewGuid().ToString());
			Console.WriteLine(Guid.NewGuid().ToString());
			Console.WriteLine(Guid.NewGuid().ToString());
			Console.WriteLine(Guid.NewGuid().ToString());
			Console.WriteLine(Guid.NewGuid().ToString());
			Console.WriteLine(Guid.NewGuid().ToString());
			Console.WriteLine(Guid.NewGuid().ToString());
			Console.WriteLine(Guid.NewGuid().ToString());
			Console.ReadKey();
		}
	}
}
