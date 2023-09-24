using Microsoft.EntityFrameworkCore;
using PeopleManagement.Domain.Entities;

namespace PeopleManagement.Infrastructure;

public static class ModelBuilderExtensions
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Person>().HasData(
            new Person { Id = 1, IdentityNumber = "901321446561", Name = "Nokukhanya", Surname = "Dumakude", Email = "khanyods3@gmail.com", CellPhone = "0798003239" },
            new Person { Id = 2, IdentityNumber = "901321446562", Name = "Nokukhanya", Surname = "Dumakude", Email = "khanyods3@gmail.com", CellPhone = "0798003239" },
            new Person { Id = 3, IdentityNumber = "901321446563", Name = "Nokukhanya", Surname = "Dumakude", Email = "khanyods3@gmail.com", CellPhone = "0798003239" },
            new Person { Id = 4, IdentityNumber = "901321446564", Name = "Nokukhanya", Surname = "Dumakude", Email = "khanyods3@gmail.com", CellPhone = "0798003239" },
            new Person { Id = 5, IdentityNumber = "901321446565", Name = "Nokukhanya", Surname = "Dumakude", Email = "khanyods3@gmail.com", CellPhone = "0798003239" },
            new Person { Id = 6, IdentityNumber = "901321446566", Name = "Nokukhanya", Surname = "Dumakude", Email = "khanyods3@gmail.com", CellPhone = "0798003239" },
            new Person { Id = 7, IdentityNumber = "901321446567", Name = "Nokukhanya", Surname = "Dumakude", Email = "khanyods3@gmail.com", CellPhone = "0798003239" },
            new Person { Id = 8, IdentityNumber = "901321446568", Name = "Nokukhanya", Surname = "Dumakude", Email = "khanyods3@gmail.com", CellPhone = "0798003239" }

        );
    }
}
