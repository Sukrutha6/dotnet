using System;
class Program
{
    static Dictionary<string, int> ConsolidateCart(List<(string sku, int qty)> scans)
    {
        Dictionary<string, int> skuQty = new Dictionary<string, int>();

        foreach (var scan in scans)
        {
            // Ignore invalid quantities
            if (scan.qty <= 0)
                continue;

            if (skuQty.ContainsKey(scan.sku))
            {
                skuQty[scan.sku] += scan.qty; // Add to existing qty
            }
            else
            {
                skuQty[scan.sku] = scan.qty;  // Add new SKU
            }
        }

        return skuQty;
    }

    static void Main()
    {
        var scans = new List<(string sku, int qty)>
        {
            ("A101", 2),
            ("B205", 1),
            ("A101", 3),
            ("C111", -1)
        };

        var result = ConsolidateCart(scans);

        foreach (var item in result)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
    }
}
