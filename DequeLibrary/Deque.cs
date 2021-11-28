using System;
using System.Collections;
using System.Collections.Generic;

namespace DequeLibrary
{
    public class Deque<T> : IEnumerable<T>
    {
        public delegate void DequeStateHandler(string message);
        DequeStateHandler _dequeStateDelegate;
        public void RegisterHandler(DequeStateHandler dequeStateDelegate)
        {
            _dequeStateDelegate += dequeStateDelegate;
        }
        public void UnregisterHandler(DequeStateHandler dequeStateDelegate)
        {
            _dequeStateDelegate -= dequeStateDelegate;
        }

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

            _dequeStateDelegate?.Invoke($"Item {data} was added as the last.");
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

            _dequeStateDelegate?.Invoke($"Item {data} was added as the first.");
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

            _dequeStateDelegate?.Invoke($"Item {temp} was removed from the end.");

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

            _dequeStateDelegate?.Invoke($"Item {temp} was removed from the start.");

            return temp;
        }

        public bool Contains(T data)
        {
            if (data == null)
            {
                throw new Exception("Incorrect input");
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
}
