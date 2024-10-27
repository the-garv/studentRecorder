using System.ComponentModel.DataAnnotations;

namespace Student.Service.Models;

public record Student
{
    [Key]
    public required long Id { get; set; }
    
    public required string FirstName { get; set; }
    
    public required string LastName { get; set; }
    
    public required int Age { get; set; }
    
    public required string Email { get; set; }
    
    public required string Phone { get; set; }
    
    public required string Address { get; set; }
}