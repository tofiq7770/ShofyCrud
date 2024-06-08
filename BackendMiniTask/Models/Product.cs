﻿namespace BackendMiniTask.Models
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string? SKU { get; set; }
        public string? Color { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public ICollection<ProductImage> ProductImage { get; set; }

    }
}
