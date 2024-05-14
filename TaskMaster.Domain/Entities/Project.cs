using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskMaster.Domain.Common;

namespace TaskMaster.Domain.Entities
{
    public class Project : AuditableEntity
    {
        public int ProjectID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }

        // Foreign key properties
        public int UserID { get; set; }
        public User User { get; set; }

        // Navigation property
        public ICollection<Task> Tasks { get; set; }
    }
}
