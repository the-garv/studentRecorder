using Microsoft.EntityFrameworkCore;

namespace Student.Service.Models;

public class StudentDbContext: DbContext
{
    public DbSet<Student> Students { get; set; }

    public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
    {
        
    }
}