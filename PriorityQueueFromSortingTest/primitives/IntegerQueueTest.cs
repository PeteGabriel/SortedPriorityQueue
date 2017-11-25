using System;
using PriorityQueueFromSorting.contracts;
using PriorityQueueFromSorting.types;
using Xunit;
using Xunit.Sdk;

namespace PriorityQueueFromSortingTest.primitives
{
    public class IntegerQueueTest : IDisposable
    {
        private IMaxPriorityQueue<int> _queue;

        public IntegerQueueTest()
        {
            _queue = new MaxPriorityQueue<int>();
        }
        
        
        [Fact]
        public void InsertOneElement_QueueMustReturnThatSameElement()
        {
            _queue.Insert(3);
            Assert.True(_queue.GetMaximum() == 3);
        }

        public void Dispose()
        {
            _queue.Dispose();
        }
    }
}