using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMaster.Domain.Common
{
    public abstract class AuditableEntity : BaseEntity
    {
        public DateTime CreationDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public int CreatorUserID { get; set; }
        public int LastModifierUserID { get; set; }
    }
}
