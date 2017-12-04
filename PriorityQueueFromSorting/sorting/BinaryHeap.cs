using System;

namespace PriorityQueueFromSorting.sorting
{
    /// <summary>
    /// Data structure for efficiently supporting the priority 
    /// queue operations insert and extract-min. They work by maintaining a partial order 
    /// on the set of elements which is weaker than the sorted order (so it can be efficient 
    /// to maintain) yet stronger than random order (so the minimum element can be 
    /// quickly identified).
    /// </summary>
    public sealed class BinaryHeap<T>
    {
        private T[] _sequence;
        
        public BinaryHeap(T[] sequence)
        {
            _sequence = sequence;
        }

        public T ExtractMin()
        {
            throw new NotImplementedException();
        }
    }
}