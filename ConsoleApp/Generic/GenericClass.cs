using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Generic {
    /*
     * 泛型类实例化的理论
     * C#泛型类在编译时，先生成中间代码IL，通用类型T只是一个占位符。在实例化类时，根据用户指定的数据类型代替T并由即时编译器（JIT）生成本地代码，这个本地代码中已经使用了实际的数据类型，等同于用实际类型写的类，所以不同的封闭类的本地代码是不一样的。按照这个原理，我们可以这样认为：
     * 泛型类的不同的封闭类是分别不同的数据类型。
     * 例：Stack<int>和Stack<string>是两个完全没有任何关系的类，你可以把他看成类A和类B，这个解释对泛型类的静态成员的理解有很大帮助。
     */
    class GenericClass<T, V> // 泛型T，V
        where T : IComparable, new()  //表示T必须继承自类或实现接口，new()表示此类中要实例化T，要求T提供无参数的构造函数
        where V : class // struct表示V必须是值传递类型如int，class表示V必须是引用传递类型如object
        { 
        T t;
        V v;
        public GenericClass() {
            t = new T();
            //v = new V(); //错误，没有new()约束，不能实例化
        }
        public int Compare(T t2) {
            return t.CompareTo(t2); // 因为泛型限制T实现了IComparable，所以可以用
        }
    }
}
