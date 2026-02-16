using System;
class Program
{
    static List<int> GetFirstUniqueEntries(List<int> scans)
    {
        HashSet<int> seen = new HashSet<int>();
        List<int> firstTime = new List<int>();

        foreach (int id in scans)
        {
            if (!seen.Contains(id))
            {
                seen.Add(id);
                firstTime.Add(id);
            }
        }

        return firstTime;
    }

    static void Main()
    {
        var scans = new List<int> { 10, 20, 10, 30, 20, 40 };

        var result = GetFirstUniqueEntries(scans);

        Console.WriteLine(string.Join(", ", result));
    }
}
