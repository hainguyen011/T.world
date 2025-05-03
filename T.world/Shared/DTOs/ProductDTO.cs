using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T.world.Shared.DTOs
{
    public class ProductDTO
    {
        public Guid? id { get; set; }
        public string name { get; set; }
        public Guid categoryId { get; set; }
        public Guid brandId { get; set; }
        public string image { get; set; }
        public string description { get; set; }
        public decimal priceSell { get; set; }
        public int quantity { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }
}
