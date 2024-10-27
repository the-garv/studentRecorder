using GraphQL.Types;
using Student.Service.GraphQL.Query;

namespace Student.Service.GraphQL;

public class StudentSchema: Schema
{
    public StudentSchema(StudentQuery studentQuery)
    {
        this.Query = studentQuery;
    }
}