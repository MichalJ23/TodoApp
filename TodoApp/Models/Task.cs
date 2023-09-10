using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.ComponentModel.DataAnnotations;
using TodoApp.Data;

namespace TodoApp.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }

        [Display(Name ="Created at"), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}")]

        [DataType(DataType.DateTime)]
        public DateTime CreatedAt { get; set; } = System.DateTime.Now;

        [Display(Name = "Done at")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", NullDisplayText = "Not done")]
        public DateTime? DoneAt { get; set; }

        [Display(Name = "Priority")]
        [EnumDataType(typeof(Priority))]
        public Priority Priority { get; set; }

        public bool IsDone { get; set; }


        [Display(Name = "Status")]
        public string DisplayIsDone
        {
            get
            {
                return IsDone ? "Done" : "Not done";
            }
        }

        public string GetPriorityColor
        {
            get
            {
                switch (Priority)
                {
                    case Priority.Low:
                        return "text-primary";
                    case Priority.Medium:
                        return "text-warning";
                    case Priority.High:
                        return "text-danger";
                }
                return "";
            }
        }
    }
}
