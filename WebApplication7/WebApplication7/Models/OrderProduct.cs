﻿namespace WebApplication7.Models
{
    public class OrderProduct
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
        public Order Order { get; set; }
        public int OrderId { get; set; }
    }
}
