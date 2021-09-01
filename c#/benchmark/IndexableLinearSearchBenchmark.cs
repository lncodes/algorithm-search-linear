using BenchmarkDotNet.Attributes;

namespace Lncodes.Algorithm.Search.Linear.Benchmark
{
    [MinColumn]
    [MaxColumn]
    [MemoryDiagnoser]
    public class IndexableLinearSearchBenchmark : LinearSearchBenchmark
    {
        private readonly IndexableLinearSearch _indexableLinearSearch = new IndexableLinearSearch();

        [Benchmark]
        public int Search() =>
            _indexableLinearSearch.Search(Data, Element);
    }
}
