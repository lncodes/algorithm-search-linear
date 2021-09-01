using Xunit;
using System.Collections.Generic;

namespace Lncodes.Algorithm.Search.Linear.Test
{
    public sealed class IndexableLinearSearchTest
    {
        [Theory]
        [ClassData(typeof(IndexableLinearSearchTheoryData))]
        public void Search_Linear_ShouldTrue(IReadOnlyList<object> data, object element, int expected)
        {
            var instance = new IndexableLinearSearch();
            var actual = instance.Search(data, element);
            Assert.Equal(expected, actual);
        }
    }
}
