using System;
class Program
{
    static Dictionary<string, decimal> CalculateSpendByCategory(
        List<(string category, decimal amount)> txns)
    {
        Dictionary<string, decimal> spendByCategory = new Dictionary<string, decimal>();

        foreach (var txn in txns)
        {

            if (txn.amount < 0)
            {
                decimal spend = Math.Abs(txn.amount);

                if (spendByCategory.ContainsKey(txn.category))
                {
                    spendByCategory[txn.category] += spend;
                }
                else
                {
                    spendByCategory[txn.category] = spend;
                }
            }
        }

        return spendByCategory;
    }

    static void Main()
    {
        var txns = new List<(string category, decimal amount)>
        {
            ("Food", -200),
            ("Fuel", -500),
            ("Food", -50),
            ("Salary", 1000)
        };

        var result = CalculateSpendByCategory(txns);

        foreach (var item in result)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
    }
}
