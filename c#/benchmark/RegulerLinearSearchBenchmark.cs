using BenchmarkDotNet.Attributes;

namespace Lncodes.Algorithm.Search.Linear.Benchmark
{
    [MinColumn]
    [MaxColumn]
    [MemoryDiagnoser]
    public class RegulerLinearSearchBenchmark : LinearSearchBenchmark
    {
        private readonly LinearSearch _linearSearch = new LinearSearch();

        [Benchmark]
        public int Search() =>
            _linearSearch.Search(Data, Element);
    }
}
