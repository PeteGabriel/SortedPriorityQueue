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
        #region State
        
        private int _size;
        private int _initialCapacity;
        private T[] _queue;
        
        #endregion
        
        //private bool _isGenericTypeInt;

        private Func<T, T, bool> _priorityPredicate;
        private IComparable<T> _comparator;
               
        private bool IsUsingPredicate => _priorityPredicate != null;
        
        private bool IsUsingComparator => _comparator != null;

        #region Constructors
        
        public MaxPriorityQueue()
        {
            _size = 0;
            _initialCapacity = 11;
            _queue = new T[_initialCapacity];
        }

        public MaxPriorityQueue(int initialCapacity)
        {
            _size = 0;
            _initialCapacity = initialCapacity;
            _queue = new T[_initialCapacity];
        }
        
        public MaxPriorityQueue(Func<T, T, bool> predicate): this()
        {
            _priorityPredicate = predicate;
        }
        
        public MaxPriorityQueue(IComparable<T> comparable): this()
        {
            _comparator = comparable;
        }
        
        public MaxPriorityQueue(Func<T, T, bool> predicate, int initialCapacity): this(initialCapacity)
        {
            _priorityPredicate = predicate;
        }
        
        public MaxPriorityQueue(IComparable<T> comparable, int initialCapacity): this(initialCapacity)
        {
            _comparator = comparable;
        }
        
        #endregion
        
        
        /// <summary>
        /// Return, without removing, the item with the highest priority.
        /// </summary>
        public T Peek()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Return the total number of elements inside the queue.
        /// </summary>
        public int Size() => _size;

        public void Insert(T item)
        {
            if (_size >= _queue.Length - 1)//resize if needed
            {
                Array.Resize(ref _queue, _queue.Length * 2);
            }
            _size+=1; //one more element
            
            throw new NotImplementedException();
        }

        public T GetMaximum()
        {
            throw new NotImplementedException();
        }

    
    }

}