using System;
class Program
{
    static string MostFrequentError(List<string> codes)
    {
        Dictionary<string, int> freq = new Dictionary<string, int>();

        foreach (var code in codes)
        {
            if (freq.ContainsKey(code))
                freq[code]++;
            else
                freq[code] = 1;
        }

        int maxFreq = 0;
        string result = "";

        foreach (var kvp in freq)
        {
            string code = kvp.Key;
            int count = kvp.Value;

            if (count > maxFreq)
            {
                maxFreq = count;
                result = code;
            }
            else if (count == maxFreq)
            {
                if (string.Compare(code, result) < 0)
                {
                    result = code;
                }
            }
        }

        return result;
    }

    static void Main()
    {
        var codes = new List<string>
        {
            "E02", "E01", "E02", "E01", "E03"
        };

        Console.WriteLine(MostFrequentError(codes));
    }
}
