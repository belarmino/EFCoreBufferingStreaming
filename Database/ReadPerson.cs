using BenchmarkDotNet.Attributes;
using EFCoreBufferingStreaming.Database.Context;
using EFCoreBufferingStreaming.Database.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreBufferingStreaming.Database
{
    [MemoryDiagnoser]
    public class ReadPerson
    {
        PersonContext db;
        [GlobalSetup]
        public void ReadPersonInit()
        {
            db = new PersonContext();
        }
        [Benchmark]
        public void ReadPersonBuffering()
        {
            List<Person> people = db.Person.AsNoTracking().ToList();
        }
        [Benchmark]
        public void ReadPersonStreaming()
        {
            IEnumerable<Person> people = db.Person.AsNoTracking();
        }
    }
}
