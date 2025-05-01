using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class BatchDTO
{
    public Guid productId { get; set; }
    public Guid supplierId { get; set; }
    public string batchCode { get; set; }
    public decimal purchasePrice { get; set; }
    public int amount { get; set; }
    public string notes { get; set; }
    public DateTime importDate { get; set; }
    public DateTime createdAt { get; set; } = DateTime.UtcNow;
    public DateTime updatedAt { get; set; } = DateTime.UtcNow;
}