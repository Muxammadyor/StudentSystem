namespace Yakuniy.Domain.Contexts;

public class Student
{

    public Guid Id { get; set; }
    public string Pasword { get; set; }
    public Guid Salt { get; set; }
    public string emile { get; set; }
    public string LastName { get; set; }
    public string? FirstName { get; set; }
    public int Cours { get; set; }
    public int? SubjectId { get; set; }
    public Subject? Subject { get; set; }
}
