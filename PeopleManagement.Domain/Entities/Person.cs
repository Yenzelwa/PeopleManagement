namespace PeopleManagement.Domain.Entities;

public class Person
{
    public int Id { get; set; }
    public string IdentityNumber { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public string CellPhone { get; set; }
}
