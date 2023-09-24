using PeopleManagement.Domain.Entities;

namespace PeopleManagement.Domain.Interfaces;

public interface IPersonRepository
{
    public IEnumerable<Person> GetPeople();
    public Person GetPerson(int id);
    public void AddPerson(Person person);
    public void EditPerson(Person person);
    public void DeletePerson(int id);
}
