using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadinaBakeryPos.Models
{
    public class AuditLog
    {
        public int Id { get; set; }
        public string TableName { get; set; } = "";
        public int? RecordId { get; set; }
        public string Action { get; set; } = "";
        public string? OldValues { get; set; }
        public string? NewValues { get; set; }
        public int? ChangedBy { get; set; }
        public DateTime ChangedAt { get; set; }

        public User? User { get; set; }
    }

}
