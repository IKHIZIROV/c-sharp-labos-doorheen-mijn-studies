using BenchmarkDotNet.Running;

namespace Project.Benchmarking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<MemoryBenchmarker>();
        }
    }
}