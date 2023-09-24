using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using PeopleManagement.Application.Services;
using PeopleManagement.Domain.Entities;

namespace PeopleManagement.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PeopleController : ControllerBase
{
    private readonly PersonService _personService;

    public PeopleController(PersonService personService)
    {
        _personService = personService;
    }
    [HttpGet]
    public ActionResult<IEnumerable<Person>> GetPeolpe()
    {
        var people = _personService.GetPeople();
        return Ok(people);
    }
}
