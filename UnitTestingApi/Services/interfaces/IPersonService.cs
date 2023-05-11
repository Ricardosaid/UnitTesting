using UnitTestingApi.Models;

namespace UnitTestingApi.Services.interfaces;

public interface IPersonService
{
    public IEnumerable<Person> Get();
    public Person? Get(int id);
}