﻿using Benchmark;
using BenchmarkDotNet.Running;

var summary = BenchmarkRunner.Run(typeof(SampleStruct).Assembly);
