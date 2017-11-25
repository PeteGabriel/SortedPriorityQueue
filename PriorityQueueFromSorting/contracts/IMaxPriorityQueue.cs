using System;

namespace PriorityQueueFromSorting.contracts
{
    public interface IMaxPriorityQueue<T> : IDisposable
    {
        void Insert(T item);

        T GetMaximum();
    }
}