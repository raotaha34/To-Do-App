namespace TodoApp.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public required string Task { get; set; } // or string? Task if nullable
        public bool IsCompleted { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
