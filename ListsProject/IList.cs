using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTSLib
{
    interface IList<T>
    {
        int Size { get; }

        T this[int index] { get; set; }

        T Get(int index);

        void Set(int index, T element);

        void Add(T element);

        void Insert(int index, T element);

        T Remove(int index);

        bool IsEmpty();

        void ForEach(Action<T> action);

        T Find(Predicate<T> criteria);

        //ArrayList<T> FindAll(Predicate<T> criteria);
    }
}
