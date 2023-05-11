using Bogus;

namespace EFCoreBufferingStreaming.Data
{
    public class GenerateConfig
    {
        public static List<Database.Models.Person> FakePersonDataConfig(int number) {
            int PersonIds = 1;
            Faker<Database.Models.Person> person = new Faker<Database.Models.Person>()
            .RuleFor(u => u.PersonId, f => PersonIds++)
            .RuleFor(u => u.FirstName, f => f.Name.FirstName())
            .RuleFor(u => u.LastName, f => f.Name.LastName())
            .RuleFor(u => u.Country, f => f.Address.Country())
            .RuleFor(u => u.City, f=> f.Address.County())
            .RuleFor(u => u.DateOfBirth, f => f.Date.Past());
            return person.Generate(number);
        }
    }
}
