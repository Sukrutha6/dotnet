using System;
class Program
{
    static List<string> GetDuplicateSerials(List<string> serials)
    {
        HashSet<string> seen = new HashSet<string>();
        HashSet<string> addedDuplicates = new HashSet<string>();
        List<string> duplicates = new List<string>();

        foreach (var serial in serials)
        {
            if (!seen.Add(serial)) 
            {
                if (!addedDuplicates.Contains(serial))
                {
                    duplicates.Add(serial);
                    addedDuplicates.Add(serial);
                }
            }
        }

        return duplicates;
    }

    static void Main()
    {
        var serials = new List<string>
        {
            "S1", "S2", "S1", "S3", "S2", "S2"
        };

        var result = GetDuplicateSerials(serials);

        Console.WriteLine(string.Join(", ", result));
    }
}
