using System;

namespace PriorityQueueFromSorting.contracts
{
    public abstract class PriorityQueue<T>:  IQueue<T>
    {
        #region State
        
        protected int _size;
        protected int _initialCapacity;
        protected T[] _queue;
        
        #endregion

        /// <summary>
        /// Return, without removing, the item with the highest priority.
        /// </summary>
        public virtual T Peek() => _queue[0];

        /// <summary>
        /// Return the total number of elements inside the queue.
        /// </summary>
        public virtual int Size() => _size;
          
        /// <summary>
        /// Check if the internal structure is empty.
        /// </summary>
        public bool IsEmpty() => _size == 0;
        
        public abstract void Insert(T item);

        public abstract T GetMaximum();
    }
}