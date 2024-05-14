using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskMaster.Domain.Common;

namespace TaskMaster.Domain.Entities
{
    public class User : AuditableEntity
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; } // Should be hashed
        public string FullName { get; set; }
        public string ProfilePicture { get; set; }        
        public DateTime LastLoginDate { get; set; }
        public UserRole Role { get; set; } // Enum: Normal, Admin

        // Navigation properties
        public ICollection<Task> Tasks { get; set; }
        public ICollection<Project> Projects { get; set; }
    }
    public enum UserRole
    {
        Normal,
        Admin
    }
}
