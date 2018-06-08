using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Basic {
    class LearnIndexer {
        static void Main(string[] args) {
            LearnIndexer indexer = new LearnIndexer();
            indexer[0] = "Zara";
            indexer[1] = "Riz";
            indexer[2] = "Asif";
            indexer[3] = "Rubic";
            for (int i = 0; i < LearnIndexer.SIZE; i++) {
                Console.WriteLine(indexer[i]);
            }
            // 重载了另一个字符串索引器
            Console.WriteLine(indexer["Asif"]);
            Console.WriteLine(indexer["Rubic"]);
            Console.ReadKey();
        }
        static int SIZE = 10;
        string[] nameList = new string[SIZE];
        public LearnIndexer() {
            for (int i = 0; i < SIZE; i++) {
                nameList[i] = "N.A.";
            }
        }
        public string this[int index] {
            get {
                string tmp;
                if (index>=0 && index<=SIZE-1) {
                    tmp = nameList[index];
                } else {
                    tmp = "";
                }
                return (tmp);
            }
            set {
                if (index>=0 && index<=SIZE-1) {
                    nameList[index] = value;
                }
            }
        }
        public int this[string name] {
            get {
                int index = 0;
                while (index<SIZE) {
                    if (nameList[index] == name) {
                        return index;
                    }
                    index++;
                }
                return index;
            }
            set {

            }
        }
    }
}
