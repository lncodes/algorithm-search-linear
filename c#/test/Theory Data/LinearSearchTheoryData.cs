using Xunit;
using System.Collections.Generic;

namespace Lncodes.Algorithm.Search.Linear.Test
{
    public sealed class LinearSearchTheoryData : TheoryData<IEnumerable<object>, object, int>
    {
        public LinearSearchTheoryData()
        {
            Add(new Queue<object>(new object[] { 1, 2, 3, 4, 5 }), 1, 0);
            Add(new Stack<object>(new object[] { "Lncodes", "Games", "Programming", "Tutorial" }), "Lncodes", 3);
            Add(new LinkedList<object>(new object[] { 'L', 'n', 'c', 'o', 'd', 'e', 's' }) , 's', 6);
        }
    }
}
