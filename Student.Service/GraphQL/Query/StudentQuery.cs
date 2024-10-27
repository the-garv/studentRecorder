using GraphQL.Types;
using Student.Service.GraphQL.Types;
using Student.Service.Repository;

namespace Student.Service.GraphQL.Query;

public sealed class StudentQuery:ObjectGraphType
{
    public StudentQuery(StudentRepository studentRepository)
    {
        Field<ListGraphType<StudentType>>("courses")
            .Description("List of courses")
            .ResolveAsync(async _ => await studentRepository.GetAsync(new List<long>()));
    }
}