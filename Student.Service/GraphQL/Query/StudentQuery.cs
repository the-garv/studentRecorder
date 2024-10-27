using GraphQL;
using GraphQL.Types;
using Student.Service.GraphQL.Types;
using Student.Service.Repository;

namespace Student.Service.GraphQL.Query;

public sealed class StudentQuery:ObjectGraphType
{
    public StudentQuery(StudentRepository studentRepository)
    {
        Field<ListGraphType<StudentType>>("students")
            .Description("List of students")
            .Argument<NonNullGraphType<ListGraphType<LongGraphType>>>("ids")
            .ResolveAsync(async context => await studentRepository.GetAsync(context.GetArgument<IReadOnlyList<long>>("ids")));
    }
}