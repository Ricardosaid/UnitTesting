using Microsoft.AspNetCore.Mvc;
using UnitTestingApi.Controllers;
using UnitTestingApi.Models;
using UnitTestingApi.Services.interfaces;

namespace PruebasUnitarias;

public class PersonService
{
    //Recursos necesarios
    private readonly PersonController _personController;
    private readonly IPersonService _personService;

    public PersonService()
    {
        _personService = new UnitTestingApi.Services.PersonService();
        _personController = new PersonController(_personService);
    }

    [Fact]
    public void ObtenerPersonOk()
    {
        //escenario es la invocacion
        //La ejecucion
        var result = _personController.ObtenerPersona();
        //Evaluacion
        Assert.IsType<OkObjectResult>(result);

    }

    [Fact]
    public void ObtenerPersonaCantidad()
    {
        var result = (OkObjectResult)_personController.ObtenerPersona();
        var personas = Assert.IsType<List<Person>>(result.Value);
        Assert.True(personas.Count > 0,"Si existen personas en la coleccion");

    }
    
    
}