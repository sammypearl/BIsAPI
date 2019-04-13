using System;

namespace BIs.API.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Customer { get; set; }
        public decimal Total { get; set; }
        public DateTime Placed { get; set; }
        public DateTime? Completed { get; set; }
        
    }
}