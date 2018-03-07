using System;
using PriorityQueueFromSorting.contracts;
using PriorityQueueFromSorting.types;
using Xunit;
using Xunit.Sdk;

namespace PriorityQueueFromSortingTest.primitives
{
    public class IntegerQueueTest
    {
        private readonly MaxPriorityQueue<int> _queue;

        public IntegerQueueTest()
        {
            _queue = new MaxPriorityQueue<int>();
        }
        
        
        [Fact]
        public void InsertOneElement_QueueMustRemoveThatSameElement()
        {
            _queue.Insert(3);
            Assert.True(_queue.GetMaximum() == 3);
            Assert.True(_queue.Size() == 0);
        }

        [Fact]
        public void WhenUsingPeekOperation_ShouldNotRemoveElementsFromQueue()
        {
            _queue.Insert(3);
            Assert.True(_queue.Peek() == 3);
            Assert.True(_queue.Size() == 1);
        }

    }
}