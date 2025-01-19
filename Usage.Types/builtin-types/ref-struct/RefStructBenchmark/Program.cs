using BenchmarkDotNet.Running;
using RefStructBenchmark.Measurements;

BenchmarkRunner.Run(typeof(InitializeMeasurement).Assembly);
BenchmarkRunner.Run(typeof(CallOverrideMethod).Assembly);
