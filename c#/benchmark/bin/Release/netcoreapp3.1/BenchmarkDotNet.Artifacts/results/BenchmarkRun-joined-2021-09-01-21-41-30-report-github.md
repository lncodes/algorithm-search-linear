``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19042.1165 (20H2/October2020Update)
AMD Ryzen 3 4300U with Radeon Graphics, 1 CPU, 4 logical and 4 physical cores
.NET SDK=5.0.202
  [Host]     : .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT  [AttachedDebugger]
  DefaultJob : .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT


```
|                           Type | Method |     Mean |    Error |   StdDev |      Min |      Max |  Gen 0 | Allocated |
|------------------------------- |------- |---------:|---------:|---------:|---------:|---------:|-------:|----------:|
| IndexableLinearSearchBenchmark | Search | 16.47 ns | 0.357 ns | 0.862 ns | 15.19 ns | 18.99 ns | 0.0229 |      48 B |
|   RegulerLinearSearchBenchmark | Search | 91.56 ns | 1.796 ns | 2.459 ns | 87.93 ns | 97.28 ns | 0.1301 |     272 B |
