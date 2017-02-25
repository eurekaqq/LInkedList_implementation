using Console = System.Console;
using LinkedList;

namespace main {
    class main {
        static void Main(string[] args) {
            LinkedList<int> a = new LinkedList<int>(123);
            Console.WriteLine(a.count);
            a.addLast(5);
            a.addLast(123);
            a.addLast(123);
            a.addLast(123);
            a.addLast(123);
            a.remove(123);
            a.remove(5);
            Console.WriteLine(a.first.data);
            Console.WriteLine(a.last.data);
            Console.WriteLine(a.count);
            a.clear();
            Console.Read();
        }
    }
}
