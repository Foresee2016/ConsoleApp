using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Basic {
    class LearnCollection {
        static void Main(string[] args) {
			int n = 5;
			List<int> ints = new List<int>(n);
			for (int i = 0; i < n; i++) {
				ints.Add(i);
			}
			Console.WriteLine(ints.Count);
			foreach (var i in ints) {
				Console.WriteLine(i);
			}

			List<string> list = new List<string>();
			list.Add("asdf");
			string[] temArr = { "Ha", "Hunter", "Locu", "Tom", "Lily", "Jay", "Jim", "Kuku" };
			List<string> list2 = new List<string>(temArr);
			list.AddRange(list2);
			foreach (var str in list) {
				Console.WriteLine(str);
			}
			Console.WriteLine(list.Remove("Ha"));
			list.RemoveAt(1);
			list.RemoveRange(2, 3);
			list.Insert(1, "qwer");
			Console.WriteLine(list.Contains("Tom"));
			list.Sort();
			Console.WriteLine(list);
			list.Reverse();
			Console.WriteLine(list);
			Console.WriteLine(list.Count);
			IEnumerable<string> whereList = list.Where(name => {
				if (name.Length > 3) {
					return true;
				} else {
					return false;
				}
			});
			foreach (var str in whereList) {
				Console.WriteLine("whereList: "+str);
			}
			string[] strArr = list.ToArray();

			Console.WriteLine("-----------------");
			Hashtable hashtable = new Hashtable();
			hashtable.Add("asdf", "hjkl");
			hashtable.Add(123, 456);
			//hashtable.Add(123, 789); //System.ArgumentException:“已添加项。字典中的关键字:“123”所添加的关键字:“123””
			hashtable[123] = 890;
			hashtable[147] = 258;
			hashtable[369] = 159;
			Console.WriteLine(hashtable["asdf"]);
			Console.WriteLine(hashtable[123]);
			Console.WriteLine(hashtable.Contains(123));
			foreach (DictionaryEntry item in hashtable) {
				Console.WriteLine("{0}, {1}",item.Key, item.Value);
			}
			hashtable.Clear();
			Console.WriteLine(hashtable[123]);

			Console.WriteLine("-----------");
			Dictionary<string, string> dict = new Dictionary<string, string>();
			dict["abc"] = "qwer";
			dict["jkl"] = "uoip";
			dict["wert"] = "tufghj";
			foreach (string str in dict.Keys) {
				Console.WriteLine("{0}, {1}", str, dict[str]);
			}
			dict["abc"] = "cvnvcnb";
			Console.WriteLine("{0}, {1}", "abc", dict["abc"]);

			Stack<int> stack = new Stack<int>();
			Queue<int> queue = new Queue<int>();
			
			BitArray bitArray = new BitArray(8);
			
			SortedList sortedList = new SortedList();
			ArrayList arrayList = new ArrayList();

			Console.ReadKey();
        }
    }
}
