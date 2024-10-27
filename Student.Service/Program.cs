using Student.Service.Models;
using Student.Service.Repository;
using GraphiQl;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateSlimBuilder(args);

builder.Services.AddDbContext<StudentDbContext>(db => db.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<IStudentRepository, StudentRepository>();

var app = builder.Build();
app.UseGraphiQl("/graphql");
app.Run();