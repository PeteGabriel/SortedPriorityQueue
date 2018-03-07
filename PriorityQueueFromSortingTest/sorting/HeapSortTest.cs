using PriorityQueueFromSorting.sorting;
using Xunit;

namespace PriorityQueueFromSortingTest.sorting
{
    public class BinaryHeapTest
    {
        [Fact]
        public void WhenSortingAlgorithm_AppliedToGivenSetOfIntegers_ExpectBinaryHeap()
        {
            var input = new[] { 3 ,2 ,1 ,7 ,8 ,4 ,10 ,16 ,12};
            var expectedOutput = new[] {1,2,3,4,7,8,10,12,16};
            var output = HeapSort<int>.Sort(input);
            for (var i = 0; i < output.Length; i++)
            {
                Assert.Equal(expectedOutput[i], output[i]);
            }
        }
    }
}