using System;
using System.Collections;
using System.Collections.Generic;

namespace Deck
{
    public class Item<T>
    {
        public T Data { get; set; }
        public Item(T data)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }
            Data = data;
        }
        public Item<T> Next { get; set; }
        public Item<T> Previous { get; set; }
    }

    public class Deque<T> : IEnumerable<T>
    {
        private Item<T> _head = null;
        private Item<T> _tail = null;
        private int count = 0;

        public void AddLast(T data)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            Item<T> item = new Item<T>(data);
            if (_head == null)
            {
                _head = item;
            }
            else
            {
                _tail.Next = item;
            }
            item.Previous = _tail;
            _tail = item;
            count++;
        }

        public void AddFirst(T data)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            Item<T> item = new Item<T>(data);
            if (_head == null)
            {
                _head = item;
                _tail = item;
            }
            else
            {
                _head.Previous = item;
            }
            item.Next = _head;
            _head = item;
            count++;
        }

        public T RemoveLast()
        {
            if (_head == null)
            {
                throw new Exception("Пустой дек");
            }

            T temp = _tail.Data;
            if (count == 1)
            {
                _head = null;
                _tail = null;
                count--;
                return temp;
            }

            _tail.Previous.Next = null;
            _tail = _tail.Previous;
            count--;
            return temp;
        }

        public T RemoveFirst()
        {
            if (_head == null)
            {
                throw new Exception("Пустой дек");
            }

            T temp = _head.Data;

            if (count == 1)
            {
                _head = null;
                _tail = null;
                count--;
                return temp;
            }

            _head.Next.Previous = null;
            _head = _head.Next;
            count--;
            return temp;
        }

        public bool Contains(T data)
        {
            if (data == null)
            {
                throw new Exception("Некоректный ввод");
            }

            Item<T> current = _head;

            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    return true;
                }
                current = current.Next;
            }

            return false;
        }

        public int Count()
        {
            return count;
        }

        public bool IsEmpty()
        {
            return count == 0;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            Item<T> current = _head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Deque<string> usersDeck = new Deque<string>();
            usersDeck.AddFirst("Alice");
            usersDeck.AddLast("Kate");
            usersDeck.AddLast("Tom");

            foreach (string s in usersDeck)
                Console.WriteLine(s);

            string removedItem = usersDeck.RemoveFirst();
            Console.WriteLine("\n Удален: {0} \n", removedItem);

            foreach (string s in usersDeck)
                Console.WriteLine(s);
        }
    }
}
