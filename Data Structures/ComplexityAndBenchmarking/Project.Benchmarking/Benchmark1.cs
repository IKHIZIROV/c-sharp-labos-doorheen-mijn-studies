using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Benchmarking;

namespace Benchmark1
{
    [MemoryDiagnoser]
    public class MemoryBenchmarker
    {
        [Params(10, 100, 1000)]
        public int N;
        private int[] data;

        [GlobalSetup]
        public void GlobalSetup()
        {
            data = new int[N]; // executed once per each N value
        }

        [Benchmark]
        public void Benchmark_CalculateSum()
        {
            Benchmarking.Program.CalculateSum(data);
        }

        [Benchmark]
        public void Benchmark_TestIfEnoughMemoryIsPresent()
        {
            Benchmarking.Program.TestIfEnoughMemoryIsPresent(N);
        }
    }
}
