namespace Groups.Implementations
{
    public class SubjectEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public void ChangeName(string newName)
        {
            Name = newName;
        }
    }
}