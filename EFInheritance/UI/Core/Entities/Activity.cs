namespace Core.Entities
{
    public class Activity : Entity
    {
        public bool WorkCompleted { get; set; }
        public string AssignedTo { get; set; }
    }
}