using Student.Service.Models;
using Student.Service.Repository;
using GraphiQl;
using GraphQL;
using GraphQL.Types;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Student.Service.GraphQL;
using Student.Service.GraphQL.Query;

var builder = WebApplication.CreateSlimBuilder(args);

builder.Services.AddDbContext<StudentDbContext>(db => db.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<IStudentRepository, StudentRepository>();
builder.Services.AddScoped<StudentQuery>();
builder.Services.AddSingleton<ISchema, StudentSchema>();


var app = builder.Build();
app.UseGraphiQl("/graphql");
app.Run();