using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTSLib
{
    class LinkedList<T> : IList<T>, IEnumerable
    {
        private class Node
        {
            public T Data { get; set; }
            public Node NextNode { get; set; }

            public Node(T data)
            {
                Data = data;
                NextNode = null;
            }
        }

        private Node firstNode;

        public int Size { get; private set; }

        public LinkedList()
        {
            firstNode = null;
            Size = 0;
        }

        public T this[int index] 
        {
            get
            {
                if ((index < 0) || (index >= Size))
                {
                    throw new IndexOutOfRangeException();
                }
                Node currentNode = firstNode;
                for (int i = 0; i < index; i++)
                {
                    currentNode = currentNode.NextNode;
                }

                return currentNode.Data;
            }
            
            set
            {
                if ((index < 0) || (index >= Size))
                {
                    throw new IndexOutOfRangeException();
                }
                Node currentNode = firstNode;
                for (int i = 0; i < index; i++)
                {
                    currentNode = currentNode.NextNode;
                }

                currentNode.Data = value;
            }
        }

        public T Get(int index) => this[index];

        public void Set(int index, T element) => this[index] = element;

        public void Add(T element)
        {
            if (firstNode == null)
            {
                firstNode = new Node(element);
            }
            else
            {
                Node lastNode = firstNode;
                while (lastNode.NextNode != null)
                {
                    lastNode = lastNode.NextNode;
                }
                lastNode.NextNode = new Node(element);
            }
            Size++;
        }
        public void Insert(int index, T element)
        {
            if ((index < 0) || (index > Size))
            {
                throw new IndexOutOfRangeException();
            }
            if (index == 0)
            {
                Node newNode = new Node(element);
                newNode.NextNode = firstNode;
                firstNode = newNode;
            }
            else
            {
                Node currentNode = firstNode;
                for (int i = 0; i < index - 1; i++)
                {
                    currentNode = currentNode.NextNode;
                }

                Node newNode = new Node(element);
                newNode.NextNode = currentNode.NextNode;
                currentNode.NextNode = newNode;

            }
            Size++;
        }

        public T Remove(int index)
        {
            if ((index < 0) || (index >= Size))
            {
                throw new IndexOutOfRangeException();
            }

            if (index == 0)
            {
                T deletedData = firstNode.Data;
                firstNode = firstNode.NextNode;
                Size--;
                return deletedData;
            }
            else
            {
                Node beforeDeleteNode = firstNode;
                for (int i = 0; i < index - 1; i++)
                {
                    beforeDeleteNode = beforeDeleteNode.NextNode;
                }

                T deletedData = beforeDeleteNode.NextNode.Data;
                beforeDeleteNode.NextNode = beforeDeleteNode.NextNode.NextNode;
                Size--;
                return deletedData;
            }

        }

        public bool IsEmpty() => firstNode == null;

        public void ForEach(Action<T> action)
        {
            if (IsEmpty())
            {
                throw new IndexOutOfRangeException();
            }
            Node current = firstNode;
            for (int i = 0; i < Size; i++)
            {
                action(current.Data);
                current = current.NextNode;
            }
        }

        public void ForEach()
        {
            Node current = firstNode;
            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.NextNode;
            }
        }

        public T Find(Predicate<T> criteria)
        {
            if (IsEmpty())
            {
                throw new IndexOutOfRangeException();
            }

            Node current = firstNode;

            for (int i = 0; i < Size; i++)
            {
                if (criteria(current.Data))
                {
                    return current.Data;
                }
                else
                {
                    current = current.NextNode;
                }
            }
            return default;
        }
        private class Enumerator : IEnumerator
        {
            private int currentIndex;
            private LinkedList<T> list;

            public Enumerator(LinkedList<T> list)
            {
                this.list = list;
                currentIndex = -1;
            }
            public object Current => list[currentIndex];

            public bool MoveNext()
            {
                if (currentIndex + 1 == list.Size)
                {
                    return false;
                }
                currentIndex++;
                return true;
            }

            public void Reset() => currentIndex = -1;
        }
        public IEnumerator GetEnumerator()
        {
            return new Enumerator(this);
        }
    }
}
