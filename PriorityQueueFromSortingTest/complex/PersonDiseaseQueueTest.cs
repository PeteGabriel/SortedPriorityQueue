using PriorityQueueFromSorting.contracts;
using PriorityQueueFromSorting.types;
using Xunit;

namespace PriorityQueueFromSortingTest.complex
{
    public class PersonDiseaseQueueTest
    {
        private IMaxPriorityQueue<Person> _queue;

        public PersonDiseaseQueueTest()
        {
            _queue = new MaxPriorityQueue<Person>();
        }


        [Fact]
        public void AssertQueueRetrievesPersonWithHighestPriority()
        {
            _queue.Insert(new Person(){Name = "John", Disease = new Disease(){Name = "leukemia", Degree = 10}});
            _queue.Insert(new Person(){Name = "Sanders", Disease = new Disease(){Name = "flu", Degree = 2}});
            Assert.True(_queue.Size() == 2);
            Assert.True(_queue.GetMaximum().Name == "John");
            Assert.True(_queue.Size() == 1);
        }
        
    }
}