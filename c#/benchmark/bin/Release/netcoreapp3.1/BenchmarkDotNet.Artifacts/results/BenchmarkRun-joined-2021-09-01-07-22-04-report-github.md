``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19042.1165 (20H2/October2020Update)
AMD Ryzen 3 4300U with Radeon Graphics, 1 CPU, 4 logical and 4 physical cores
.NET SDK=5.0.202
  [Host]     : .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT  [AttachedDebugger]
  DefaultJob : .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT


```
|                           Type | Method |     Mean |    Error |   StdDev |   Median |      Min |      Max |  Gen 0 | Allocated |
|------------------------------- |------- |---------:|---------:|---------:|---------:|---------:|---------:|-------:|----------:|
| IndexableLinearSearchBenchmark | Search | 16.08 ns | 0.372 ns | 1.043 ns | 15.60 ns | 15.06 ns | 19.44 ns | 0.0229 |      48 B |
|   RegulerLinearSearchBenchmark | Search | 88.65 ns | 1.488 ns | 1.392 ns | 88.35 ns | 86.39 ns | 90.56 ns | 0.1301 |     272 B |
