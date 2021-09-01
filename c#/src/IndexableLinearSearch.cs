using System.Collections.Generic;

namespace Lncodes.Algorithm.Search.Linear
{
    public sealed class IndexableLinearSearch
    {
        /// <summary>
        /// Method to search indexable collection
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        /// <param name="element"></param>
        /// <returns cref="bool"></returns>
        public int Search<T>(IReadOnlyList<T> data, T element)
        {
            var rightPointPosition = data.Count - 1;
            for (var leftPointPosition = 0; leftPointPosition != rightPointPosition;)
            {
                if (data[leftPointPosition].Equals(element))
                    return leftPointPosition;

                if (data[rightPointPosition].Equals(element))
                    return rightPointPosition;

                leftPointPosition++;
                rightPointPosition--;
            }
            return -1;
        }
    }
}
