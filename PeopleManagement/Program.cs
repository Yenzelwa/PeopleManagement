using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using PeopleManagement.Application.Interfaces;
using PeopleManagement.Application.Services;
using PeopleManagement.Domain;
using PeopleManagement.Domain.Interfaces;
using PeopleManagement.Infrastructure.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddControllers();




builder.Services.AddDbContext<PeopleManagementContext>(options =>{
    options.UseInMemoryDatabase("PeopleManagement");
});
builder.Services.AddTransient<IPersonRepository, PersonRepository>();
builder.Services.AddScoped<IPersonService, PersonService>();



builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c => {
    c.SwaggerDoc("v1", new OpenApiInfo{ Title = "People management", Version ="v1"});
});

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>{
        c.SwaggerEndpoint("/swagger/v1/swagger.json","People management v1");
    });
}

app.UseHttpsRedirection();
app.UseRouting();
app.MapControllers();
app.Run();
