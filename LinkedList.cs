using IComparable = System.IComparable;
using GC = System.GC;
using node;

namespace LinkedList {
    class LinkedList<T> where T : IComparable {
        private node<T> _first, _last;
        private int _count;
        public int count => _count;
        public node<T> first => _first;
        public node<T> last => _last;

        public LinkedList(T data) {
            _count = 0;
            addLast(data);
        }

        public void addFirst(T data) {
            var temp = new node<T>(data);
            if (_first == null) {
                _first = temp;
                _last = temp;
            }
            else {
                temp.next = _first;
                _first = temp;
            }
            GC.Collect();
            ++_count;
        }

        public void addLast(T data) {
            var temp = new node<T>(data);
            if (_first == null) {
                _first = temp;
                _last = temp;
            }
            else {
                _last.next = temp;
                _last = temp;
            }
            GC.Collect();
            ++_count;
        }

        public void remove(T data) {
            if (_first == null) return;
            var temp = _first;
            if (_first.data.CompareTo(data) == 0) {
                _first = _first.next;
                --_count;
                GC.Collect();
                return;
            }
            for (int i = 0; i < count-1; ++i) {
                if (temp.next.data.CompareTo(data) == 0) {
                    temp.next = temp.next.next;
                    break;
                }
                temp = temp.next;
            }
            --_count;
            GC.Collect();
        }

        public void clear() {
            _first = null;
            _last = null;
            _count = 0;
            GC.Collect();
        }
    }
}
