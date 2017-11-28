using System;

namespace PriorityQueueFromSorting.contracts
{
    public interface IMaxPriorityQueue<T> : IQueue<T>
    {
        void Insert(T item);

        T GetMaximum();
    }
}