using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using PriorityQueueFromSorting.contracts;

namespace PriorityQueueFromSorting.types
{
    /// <summary>
    /// Max priority queue.
    /// 
    /// 
    /// </summary>
    /// <typeparam name="T"> Any generic type </typeparam>
    public class MaxPriorityQueue<T> : PriorityQueue<T> where T: new()
    {
        //private bool _isGenericTypeInt;

        private Func<T, T, bool> _priorityPredicate;
        private IComparer<T> _comparator;
               
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
        
        public MaxPriorityQueue(IComparer<T> comparable): this()
        {
            _comparator = comparable;
        }
        
        public MaxPriorityQueue(Func<T, T, bool> predicate, int initialCapacity): this(initialCapacity)
        {
            _priorityPredicate = predicate;
        }
        
        public MaxPriorityQueue(IComparer<T> comparable, int initialCapacity): this(initialCapacity)
        {
            _comparator = comparable;
        }
        
        #endregion
        
       
        public override void Insert(T item)
        {
            if (_size >= _queue.Length - 1)//resize if needed
            {
                Array.Resize(ref _queue, _queue.Length * 2);
            }
            _size+=1; //one more element
            _queue[_size] = item;
            //BubbleUpHeap();
            
            throw new NotImplementedException();
        }

        public override T GetMaximum()
        {
            _size-= 1; //decrease # of elements
            throw new NotImplementedException();
        }



    }

}