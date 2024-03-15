using Groups.Implementations;

namespace Students.Implementations
{
    public class TeacherEntity : PersonEntity
    {
        public string Subject { get; set; }

        public void AssignSubject(string subject)
        {
            Subject = subject;
        }
    }
}