using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Basic {
    class EditorHelp {
        /// <summary>
        /// VS里代码辅助插入，定义代码片段。内置的有for，try，if等
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args) {
            IList<int> list = new List<int>();
            for (int i = 0; i < 10; i++) { // 写for之后两次tab
                i++;
            }
            foreach (var item in list) { // 写foreach之后两次tab

            }
            do { // 写do之后两次tab

            } while (list.Contains(10));
            if (true) {
                Console.WriteLine(); // 写cw之后一次tab
            }
            try { // 写try之后两次tab

            } catch (Exception) {

                throw;
            }
            Console.ReadKey(); // 自定义的代码片段，crk之后两次tab
        }

    }
    class MyClass { //写class之后两次tab
        public MyClass() { //写ctor之后两次tab，生成空的构造
                
        }
        public int MyProperty { get; private set; } //写propg之后两次tab
        public int Aasldf { get; set; } //写prop之后两次tab
        
    }

    [Serializable]
    public class MyException : Exception { // 写Exception之后两次tab
        public MyException() { }
        public MyException(string message) : base(message) { }
        public MyException(string message, Exception inner) : base(message, inner) { }
        protected MyException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
