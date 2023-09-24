using PeopleManagement.Application.Interfaces;
using PeopleManagement.Domain.Entities;
using PeopleManagement.Domain.Interfaces;

namespace PeopleManagement.Application.Services;

public class PersonService : IPersonService
{
    private readonly IPersonRepository _personRepository;
    public PersonService(IPersonRepository  personRepository)
    {
        _personRepository = personRepository;
    }
    public void AddPerson(Person person)
    {
        throw new NotImplementedException();
    }

    public void DeletePerson(int id)
    {
        throw new NotImplementedException();
    }

    public void EditPerson(Person person)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Person> GetPeople()
    {
        return _personRepository.GetPeople();
    }

    public Person GetPerson(int id)
    {
        throw new NotImplementedException();
    }

}
