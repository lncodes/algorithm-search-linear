using Xunit;
using System.Collections.Generic;

namespace Lncodes.Algorithm.Search.Linear.Test
{
    public sealed class IndexableLinearSearchTheoryData : TheoryData<IReadOnlyList<object>, object, int>
    {
        public IndexableLinearSearchTheoryData() 
        {
            Add(new object[] { 1, 2, 3, 4 }, 3, 2);
            Add(new object[] { 'L', 'n', 'c', 'o', 'd', 'e', 's' }, 's', 6);
            Add(new List<object> { "Lncodes", "Games", "Programming", "Tutorial" }, "Lncodes", 0);
        }
    }
}
