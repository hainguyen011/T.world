using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T.world.Shared.DTOs
{
    public class SupplierDTO
    {
        public Guid? id { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string location { get; set; }
        public DateTime? createdAt { get; set; }
        public DateTime? updatedAt { get; set; }
    }
}
