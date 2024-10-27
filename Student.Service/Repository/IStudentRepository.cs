namespace Student.Service.Repository;

public interface IStudentRepository
{
    public ValueTask<IReadOnlyList<Models.Student>> GetAsync(IReadOnlyList<long> ids);
    public ValueTask<Models.Student?> GetAsync(long ids);
    public ValueTask AddAsync(Models.Student student);
    public ValueTask AddAsync(IReadOnlyList<Models.Student> students);
    public  ValueTask UpdateAsync(Models.Student student);
    public ValueTask DeleteAsync(long id);
}