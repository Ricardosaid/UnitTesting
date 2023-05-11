using Microsoft.AspNetCore.Mvc;
using UnitTestingApi.Services.interfaces;

namespace UnitTestingApi.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class PersonController : Controller
{
    private readonly IPersonService _personService;
    public PersonController(IPersonService personService)
    {
        _personService = personService;
    }

    [HttpGet]
    public IActionResult ObtenerPersona() => Ok(_personService.Get());


    [HttpGet("{id:int}")]
    public IActionResult ObtenerPersonaId(int id)
    {
        var persona = _personService.Get(id);
        if (persona == null)
            return NotFound();
        return Ok(persona);

    }
    
    
}