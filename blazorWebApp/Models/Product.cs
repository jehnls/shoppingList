using System;

namespace blazorWebApp.App.Models
{
        public class Product
        {
                public Guid ID { get; set; }
                public string Name { get; set; }
                public int? Quantity { get; set; }
                public double? UnitValue { get; set; }
                public string? Category { get; set; }
        }
}