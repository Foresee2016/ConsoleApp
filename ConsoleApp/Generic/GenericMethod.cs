using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Generic {
    class GenericMethod {
        /*
         * 泛型单独用在类的方法上，他可根据方法参数的类型自动适应各种参数，这样的方法叫泛型方法
         */
        public static void PushArr<T> (Stack<T> stack, params T[] arr) {
            foreach(T t in arr) {
                stack.Push(t);
            }
        }
    }
}
