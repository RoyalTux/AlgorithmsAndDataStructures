using Algorithms.SortAlgorithms;
using FluentAssertions;
using Xunit;

namespace AlgorithmsAndDataStructuresTests.AlgorithmsTests
{
    public class MergeSortTest
    {
        [Fact]
        public void Sort_IfLeftIndexMoreOrEqualsToRightIndex_ShouldReturnOriginArray()
        {
            var mergeSort = new MergeSort();
            var actualArray = new int[1] { 3 };
            var expectedArray = new int[1] { 3 };
            mergeSort.Sort(actualArray, 0, actualArray.Length - 1);
            actualArray.Should().NotBeNullOrEmpty();
            actualArray.ShouldBeEquivalentTo(expectedArray);
        }

        [Fact]
        public void Sort_NotSortedArray_ShouldReturnArrayWithSortedValues()
        {
            var mergeSort = new MergeSort();
            var actualArray = new int[10]
            {
                1, 5, 4, 11, 20, 8, 2, 98, 90, 16
            };
            var expectedArray = new int[10]
            {
                1, 2, 4, 5, 8, 11, 16, 20, 90, 98
            };
            mergeSort.Sort(actualArray, 0, actualArray.Length - 1);
            actualArray.Should().NotBeNullOrEmpty();
            actualArray.ShouldBeEquivalentTo(expectedArray);
        }
    }
}
