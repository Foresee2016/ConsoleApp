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
        /*
         * 泛型，导致静态成员变量的机制出现了一些变化：静态成员变量在相同封闭类间共享，不同的封闭类间不共享。
         * 这也非常容易理解，因为不同的封闭类虽然有相同的类名称，但由于分别传入了不同的数据类型，他们是完全不同的类
         */
        public static int times;

        /*
         * 重载时有些注意事项
         * 如果T和V都传入int的话，三个add方法将具有同样的签名，但这个类仍然能通过编译，是否会引起调用混淆将在这个类实例化和调用add方法时判断。
         * 引起了三个add具有同样的签名，但却能调用成功，因为他优先匹配了第三个add。但如果删除了第三个add，上面的调用代码则无法编译通过，提示方法产生的混淆，因为运行时无法在第一个add和第二个add之间选择。
         * 
         * C#的泛型是在实例的方法被调用时检查重载是否产生混淆，而不是在泛型类本身编译时检查。同时还得出一个重要原则：
         * 当一般方法与泛型方法具有相同的签名时，会覆盖泛型方法。
         */
        public T Add(T a, V b)          //第一个add
        {
            return a;
        }
        public T Add(V a, T b)          //第二个add
        {
            return b;
        }
        public int Add(int a, int b)    //第三个add
        {
            return a + b;
        }
    }
}
