using UnitTestingApi.Models;
using UnitTestingApi.Services.interfaces;

namespace UnitTestingApi.Services;

public class PersonService : IPersonService
{
    public IEnumerable<Person> Get()
    {
        throw new NotImplementedException();
    }

    public Person? Get(int id)
    {
        throw new NotImplementedException();
    }
}