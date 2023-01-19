namespace Yakuniy.Domain.Contexts
{
    public class Subject
    {
        public Guid Id { get; set; }
        public string SubjectName { get; set; }
        public int Credit { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
