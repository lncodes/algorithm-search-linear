using System.Collections.Generic;

namespace Lncodes.Algorithm.Search.Linear
{
    public sealed class LinearSearch
    {
        /// <summary>
        /// Method to search general collection
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        /// <param name="element"></param>
        /// <returns cref="bool"></returns>
        public int Search<T>(IEnumerable<T> data, T element) 
        {
            var index = 0;
            foreach(var item in data)
            {
                if (item.Equals(element))
                    return index;
                index++;
            }
            return -1;
        }
    }
}
