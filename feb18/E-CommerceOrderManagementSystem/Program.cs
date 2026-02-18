using System;
namespace ECommerceSystem
{
    class Program
    {
        static List<Product> products = new();
        static List<Customer> customers = new();
        static List<Order> orders = new();
        static Dictionary<int, Product> productDictionary = new();

        static void Main()
        {
            SeedData();

            while (true)
            {
                Console.WriteLine("\n1. Place Order");
                Console.WriteLine("2. Reports");
                Console.WriteLine("3. Exit");

                var choice = Console.ReadLine();

                try
                {
                    switch (choice)
                    {
                        case "1": PlaceOrder(); break;
                        case "2": ShowReports(); break;
                        case "3": return;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }

        static void SeedData()
        {
            products.Add(new Product { Id = 1, Name = "Laptop", Price = 80000, Stock = 20 });
            products.Add(new Product { Id = 2, Name = "Phone", Price = 30000, Stock = 5 });

            foreach (var p in products)
                productDictionary[p.Id] = p;

            customers.Add(new Customer { Id = 1, Name = "Rahul", IsBlacklisted = false });
            customers.Add(new Customer { Id = 2, Name = "Riya", IsBlacklisted = true });
        }

        static void PlaceOrder()
        {
            Console.Write("Customer Id: ");
            int custId = int.Parse(Console.ReadLine());
            var customer = customers.First(c => c.Id == custId);

            if (customer.IsBlacklisted)
                throw new CustomerBlacklistedException("Customer is blacklisted.");

            Console.Write("Product Id: ");
            int pid = int.Parse(Console.ReadLine());
            Console.Write("Quantity: ");
            int qty = int.Parse(Console.ReadLine());

            var product = productDictionary[pid];

            if (product.Stock < qty)
                throw new OutOfStockException("Insufficient stock.");

            product.Stock -= qty;

            Order order = new Order
            {
                OrderId = orders.Count + 1,
                Customer = customer
            };

            order.Items.Add(new OrderItem
            {
                Product = product,
                Quantity = qty
            });

            orders.Add(order);

            Console.WriteLine("Order placed successfully!");
            Console.WriteLine("Total after Festival Discount: " +
                order.CalculateTotal(new FestivalDiscount()));
        }

        static void ShowReports()
        {
            Console.WriteLine("\nOrders in last 7 days:");
            Console.WriteLine(orders.Count(o => o.OrderDate >= DateTime.Now.AddDays(-7)));

            Console.WriteLine("\nTotal Revenue:");
            Console.WriteLine(orders.Sum(o => o.CalculateTotal()));

            Console.WriteLine("\nMost Sold Product:");
            var mostSold = orders.SelectMany(o => o.Items)
                .GroupBy(i => i.Product.Name)
                .OrderByDescending(g => g.Sum(i => i.Quantity))
                .FirstOrDefault();
            Console.WriteLine(mostSold?.Key);

            Console.WriteLine("\nTop 5 Customers:");
            var topCustomers = orders.GroupBy(o => o.Customer.Name)
                .Select(g => new { Name = g.Key, Total = g.Sum(o => o.CalculateTotal()) })
                .OrderByDescending(x => x.Total)
                .Take(5);

            foreach (var c in topCustomers)
                Console.WriteLine(c.Name);

            Console.WriteLine("\nGroup by Status:");
            var grouped = orders.GroupBy(o => o.Status);
            foreach (var g in grouped)
                Console.WriteLine($"{g.Key}: {g.Count()}");

            Console.WriteLine("\nLow Stock Products (<10):");
            foreach (var p in products.Where(p => p.Stock < 10))
                Console.WriteLine(p.Name);
        }
    }
}
