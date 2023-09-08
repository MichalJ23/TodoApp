using System.ComponentModel.DataAnnotations;
using TodoApp.Data;

namespace TodoApp.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime CreatedAt { get; set; } = System.DateTime.Now;

        [DataType(DataType.DateTime)]
        public DateTime DueDate { get; set; }
        public Priority priority { get; set; }
        public bool IsDone { get; set; }
    }
}
