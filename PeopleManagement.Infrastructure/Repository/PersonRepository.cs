using PeopleManagement.Domain.Entities;
using PeopleManagement.Domain.Interfaces;

namespace PeopleManagement.Infrastructure.Repository;

public class PersonRepository : IPersonRepository
{
    private readonly  PeopleManagementContext _peopleManagementContext;
    public PersonRepository(PeopleManagementContext peopleManagementContext)
    {
     _peopleManagementContext = peopleManagementContext;
    }
    public IEnumerable<Person> GetPeople()
    {
        return _peopleManagementContext.People.ToArray();
    }

    public Person GetPerson(int id)
    {
        throw new NotImplementedException();
    }
      public void AddPerson(Person person)
    {
        throw new NotImplementedException();
    }

    public void EditPerson(Person person)
    {
        throw new NotImplementedException();
    }

    public void DeletePerson(int id)
    {
        throw new NotImplementedException();
    }
}
