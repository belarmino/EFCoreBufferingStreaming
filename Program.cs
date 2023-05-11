using BenchmarkDotNet.Running;
using EFCoreBufferingStreaming.Database;

Console.WriteLine("Hello, EFCoreBufferingStreaming!");

var summary = BenchmarkRunner.Run<ReadPerson>();

