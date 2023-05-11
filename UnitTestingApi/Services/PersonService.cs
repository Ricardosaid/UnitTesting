using UnitTestingApi.Models;
using UnitTestingApi.Services.interfaces;

namespace UnitTestingApi.Services;

public class PersonService : IPersonService
{

    private List<Person> _persons = new()
    {
        new Person
        {
            id = 1,
            nombre = "NombreOne",
            apellido = "apellidoOne",
            edad = 20
        },
        new Person
        {
            id = 2,
            nombre = "NombreDos",
            apellido = "apellidoDos",
            edad = 21
        }
    };

    public IEnumerable<Person> Get() => _persons;

    public Person? Get(int id) => _persons.FirstOrDefault(d => d.id == id);
}