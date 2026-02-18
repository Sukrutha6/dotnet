using System;
namespace ECommerceSystem
{
    public interface IDiscountStrategy
    {
        decimal ApplyDiscount(decimal totalAmount);
    }

    public class PercentageDiscount : IDiscountStrategy
    {
        private readonly decimal _percentage;
        public PercentageDiscount(decimal percentage)
        {
            _percentage = percentage;
        }

        public decimal ApplyDiscount(decimal totalAmount)
        {
            return totalAmount - (totalAmount * _percentage / 100);
        }
    }

    public class FlatDiscount : IDiscountStrategy
    {
        private readonly decimal _amount;
        public FlatDiscount(decimal amount)
        {
            _amount = amount;
        }

        public decimal ApplyDiscount(decimal totalAmount)
        {
            return totalAmount - _amount;
        }
    }

    public class FestivalDiscount : IDiscountStrategy
    {
        public decimal ApplyDiscount(decimal totalAmount)
        {
            return totalAmount * 0.80m; // 20% discount
        }
    }
}
