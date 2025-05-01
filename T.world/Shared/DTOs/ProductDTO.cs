using System;

public class ProductDTO
{
    public string name { get; set; }
    public Guid categoryId { get; set; }
    public Guid brandId { get; set; }
    public Guid proSpecId { get; set; }
    public string title { get; set; }
    public string shortDesc { get; set; }
    public string description { get; set; }
    public decimal priceSell { get; set; }
    public DateTime createdAt { get; set; }
    public DateTime updatedAt { get; set; }
}
