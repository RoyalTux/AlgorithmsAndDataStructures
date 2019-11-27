using Algorithms.SearchAlgorithms;
using FluentAssertions;
using Xunit;

namespace AlgorithmsAndDataStructuresTests.AlgorithmsTests
{
    public class LinearSearchTest
    {
        [Fact]
        public void Search_ShouldReturnIndexOfValue()
        {
            var array = new int[10]
            {
                1, 5, 4, 12, 20, 8, 2, 98, 90, 16
            };
            const int expectedIndex = 3;
            var linearSearch = new LinearSearch();
            var actualIndex = linearSearch.Search(array, 12);
            actualIndex.ShouldBeEquivalentTo(expectedIndex);
        }

        [Fact]
        public void Search_IfValueNotFound_ShouldReturnMinusOne()
        {
            var array = new int[10]
            {
                1, 5, 4, 12, 20, 8, 2, 98, 90, 16
            };
            const int expectedIndex = -1;
            var linearSearch = new LinearSearch();
            var actualIndex = linearSearch.Search(array, 33);
            actualIndex.ShouldBeEquivalentTo(expectedIndex);
        }
    }
}
