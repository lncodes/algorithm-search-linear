using Xunit;
using System.Collections.Generic;

namespace Lncodes.Algorithm.Search.Linear.Test
{
    public sealed class LinearSearchTest
    {
        [Theory]
        [ClassData(typeof(LinearSearchTheoryData))]
        public void Search_Linear_ShouldTrue(IEnumerable<object> data, object element, int expected)
        {
            var instance = new LinearSearch();
            var actual = instance.Search(data, element);
            Assert.Equal(expected, actual);
        }
    }
}
