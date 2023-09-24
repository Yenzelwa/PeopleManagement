using Microsoft.EntityFrameworkCore;
using PeopleManagement.Domain.Entities;

namespace PeopleManagement.Domain;

public class PeopleManagementContext: DbContext
{
   public PeopleManagementContext(DbContextOptions<PeopleManagementContext> options): base(options){}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Seed();
    }
    public DbSet<Person> People {get; set;}
}
