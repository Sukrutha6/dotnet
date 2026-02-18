using System;
namespace ECommerceSystem
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public decimal Price { get; set; }
        public int Stock { get; set; }
    }

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public bool IsBlacklisted { get; set; }
    }

    public class OrderItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }

        public decimal TotalPrice()
        {
            return Product.Price * Quantity;
        }
    }

    public enum OrderStatus
    {
        Pending,
        Shipped,
        Delivered,
        Cancelled
    }

    public class Order
    {
        public int OrderId { get; set; }
        public Customer Customer { get; set; }
        public List<OrderItem> Items { get; set; } = new();
        public DateTime OrderDate { get; set; } = DateTime.Now;
        public OrderStatus Status { get; set; } = OrderStatus.Pending;

        public decimal CalculateTotal(IDiscountStrategy? strategy = null)
        {
            decimal total = Items.Sum(i => i.TotalPrice());
            return strategy == null ? total : strategy.ApplyDiscount(total);
        }

        public void Cancel()
        {
            if (Status == OrderStatus.Shipped)
                throw new OrderAlreadyShippedException("Cannot cancel shipped order.");

            Status = OrderStatus.Cancelled;
        }
    }
}
