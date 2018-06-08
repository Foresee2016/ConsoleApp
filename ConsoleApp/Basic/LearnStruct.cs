using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
struct Book {
    public string title;
    public string author;
    public string subject;
    public int isbn;
}
namespace ConsoleApp.Basic {
    class LearnStruct {
        public static void Main(string[] args) {
            Book book1;
            Book book2;
            book1.title = "C Programming";
            book1.author = "Nuha Ali";

            book2.title = "Telecom Billing";
            book2.author = "Zara Ali";
        }
    }
}
