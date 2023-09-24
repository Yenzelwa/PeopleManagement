using PeopleManagement.Domain.Entities;

namespace PeopleManagement.Application.Interfaces;

public interface IPersonService
{
    public IEnumerable<Person> GetPeople();
    public Person GetPerson(int id);
    public void AddPerson(Person person);
    public void EditPerson(Person person);
    public void DeletePerson(int id);
}
