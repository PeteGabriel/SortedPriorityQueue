using System;
using PriorityQueueFromSorting.contracts;

namespace PriorityQueueFromSorting.types
{
    /// <summary>
    /// Max priority queue.
    /// 
    /// 
    /// </summary>
    /// <typeparam name="T"> Any generic type </typeparam>
    public class MaxPriorityQueue<T> : IMaxPriorityQueue<T> where T: new()  
    {
        
        //private bool _isGenericTypeInt;

        private Func<T, T, bool> _priorityPredicate;
        private IComparable _comparator;
        

        private bool IsUsingPredicate => _priorityPredicate != null;
        private bool IsUsingComparator => _comparator != null;

        public MaxPriorityQueue()
        {
          //_isGenericTypeInt = typeof(T) == typeof(int);
        }

        public MaxPriorityQueue(Func<T, T, bool> predicate)
        {
            _priorityPredicate = predicate;
        }
        
        public MaxPriorityQueue(IComparable comparable)
        {
            _comparator = comparable;
        }

        
        public void Insert(T item)
        {
            throw new NotImplementedException();
        }

        public T GetMaximum()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _comparator = null;
            _priorityPredicate = null;
        }
    }

}