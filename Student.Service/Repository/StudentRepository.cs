using Microsoft.EntityFrameworkCore;
using Student.Service.Models;

namespace Student.Service.Repository;

public class StudentRepository : IStudentRepository
{
    private readonly StudentDbContext _dbContext;
    
    public StudentRepository(StudentDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async ValueTask<IReadOnlyList<Models.Student>> GetAsync(IReadOnlyList<long> ids)
    {
        return await _dbContext.Students.Where(s => ids.Contains(s.Id)).ToListAsync();
    }

    public async ValueTask<Models.Student?> GetAsync(long id)
    {
        return await _dbContext.Students.FirstOrDefaultAsync(s => s.Id == id);
    }

    public async ValueTask AddAsync(Models.Student student)
    {
        _dbContext.Students.Add(student);
        await _dbContext.SaveChangesAsync();
    }

    public async ValueTask AddAsync(IReadOnlyList<Models.Student> students)
    {
        _dbContext.Students.AddRange(students);
        await _dbContext.SaveChangesAsync();
    }

    public async ValueTask UpdateAsync(Models.Student student)
    {
        _dbContext.Students.Attach(student);
        _dbContext.Students.Entry(student).State = EntityState.Modified;
        await _dbContext.SaveChangesAsync();
    }

    public async ValueTask DeleteAsync(long id)
    {
        await _dbContext.Students.Where(student => student.Id == id).ExecuteDeleteAsync(); 
        await _dbContext.SaveChangesAsync();
    }
}