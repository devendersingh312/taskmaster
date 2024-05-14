using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaskMaster.Domain.Common;

namespace TaskMaster.Domain.Entities
{
    public class Task : AuditableEntity
    {
        public int TaskID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public TaskPriority Priority { get; set; } // Enum: High, Medium, Low
        public TaskStatus Status { get; set; } // Enum: Open, InProgress, Completed
        public DateTime CreationDate { get; set; }

        // Foreign key properties
        public int UserID { get; set; }
        public User User { get; set; }

        public int? ProjectID { get; set; }
        public Project Project { get; set; }
    }
    public enum TaskPriority
    {
        High,
        Medium,
        Low
    }
    public enum TaskStatus
    {
        Open,
        InProgress,
        Completed
    }
}
