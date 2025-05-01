using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T.world.Shared.DTOs
{
    class SupplierDTO
    {
        public string name { get; set; }
        public string phone { get; set; }
        public string location { get; set; }
        public DateTime? createdAt { get; set; }
        public DateTime? updatedAt { get; set; }
    }
}
