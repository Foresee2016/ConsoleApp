using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Basic {
    class LearnException {
        static void Main(string[] args) {
            try {
                SomeClass.ThrowException();
            } catch (SomeException e) {
                Console.WriteLine("Some Error");
                Console.WriteLine(e.StackTrace);
            }
            try {
                SomeClass2.ThrowException();
            } catch (SomeException2 e) {
                Console.WriteLine(e.StackTrace);
            }
            Console.Read();
        }
    }
    public class SomeException : ApplicationException {
        public SomeException(string message) : base(message) {
              
        }
    }
    public class SomeException2 : Exception {
        public SomeException2(string message) : base(message) {

        }
    }
    public class SomeClass {
        public static void ThrowException() {
            throw new SomeException("Some Exception throwed");
        }
    }
    class SomeClass2 {
        public static void ThrowException() {
            throw new SomeException2("Exception2");
        }
    }
}
