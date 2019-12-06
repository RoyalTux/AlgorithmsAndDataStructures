using Algorithms.SortAlgorithms;
using FluentAssertions;
using Xunit;

namespace AlgorithmsAndDataStructuresTests.AlgorithmsTests
{
    public class BubbleSortTest
    {
        [Fact]
        public void SortFromEnd_NotSortedArray_ShouldReturnArrayWithSortedValues()
        {
            var bubbleSort = new BubbleSort();
            var actualArray = new int[10]
            {
                1, 5, 4, 11, 20, 8, 2, 98, 90, 16
            };
            var expectedArray = new int[10]
            {
                1, 2, 4, 5, 8, 11, 16, 20, 90, 98
            };
            bubbleSort.SortFromEnd(actualArray);
            actualArray.Should().NotBeNullOrEmpty();
            actualArray.ShouldBeEquivalentTo(expectedArray);
        }

        [Fact]
        public void SortFromStart_NotSortedArray_ShouldReturnArrayWithSortedValues()
        {
            var bubbleSort = new BubbleSort();
            var actualArray = new int[10]
            {
                1, 5, 4, 11, 20, 8, 2, 98, 90, 16
            };
            var expectedArray = new int[10]
            {
                1, 2, 4, 5, 8, 11, 16, 20, 90, 98
            };
            bubbleSort.SortFromStart(actualArray);
            actualArray.Should().NotBeNullOrEmpty();
            actualArray.ShouldBeEquivalentTo(expectedArray);
        }
    }
}
