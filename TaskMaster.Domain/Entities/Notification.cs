using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMaster.Domain.Entities
{
    public class Notification
    {
        public int NotificationID { get; set; }
        public int UserID { get; set; } // Foreign Key
        public string Content { get; set; }
        public NotificationStatus Status { get; set; } // Enum: Pending, Sent, Failed
        public DateTime? SentDate { get; set; }

        // Navigation properties
        public User User { get; set; } // Many-to-One with User
        public int? TaskID { get; set; } // Foreign Key (Nullable)
        public Task Task { get; set; } // Many-to-One with Task
    }


    public enum NotificationStatus
    {
        Pending,
        Sent,
        Failed
    }
}
