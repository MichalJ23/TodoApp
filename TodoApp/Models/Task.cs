using System.ComponentModel.DataAnnotations;
using TodoApp.Data;

namespace TodoApp.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }

        [Display(Name ="Created at")]
        [DataType(DataType.DateTime)]
        public DateTime CreatedAt { get; set; } = System.DateTime.Now;

        [Display(Name = "Done at")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(NullDisplayText = "Not done")]
        public DateTime? DoneAt { get; set; }

        [Display(Name = "Priority")]
        [EnumDataType(typeof(Priority))]
        public Priority Priority { get; set; }
        public bool IsDone { get; set; }
    }
}
