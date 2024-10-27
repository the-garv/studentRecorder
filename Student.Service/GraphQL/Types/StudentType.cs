using GraphQL.Types;

namespace Student.Service.GraphQL.Types;

public sealed class StudentType:ObjectGraphType<Models.Student>
{
    public StudentType()
    {
        Field(student => student.Id, type: typeof(IdGraphType)).Description("Student Id");
        Field(student => student.FirstName, type: typeof(StringGraphType)).Description("Student First Name");
        Field(student => student.LastName, type: typeof(StringGraphType)).Description("Student Last Name");
        Field(student => student.Email, type: typeof(StringGraphType)).Description("Student Email");
        Field(student => student.Phone, type: typeof(StringGraphType)).Description("Student Phone");
        Field(student => student.Address, type: typeof(StringGraphType)).Description("Student Address");
    }
}