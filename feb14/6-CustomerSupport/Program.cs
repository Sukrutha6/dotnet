using System;
class Program
{
    static List<int> MergeSortedLists(List<int> a, List<int> b)
    {
        List<int> merged = new List<int>();

        int i = 0, j = 0;

        while (i < a.Count && j < b.Count)
        {
            if (a[i] <= b[j])
            {
                merged.Add(a[i]);
                i++;
            }
            else
            {
                merged.Add(b[j]);
                j++;
            }
        }

        while (i < a.Count)
        {
            merged.Add(a[i]);
            i++;
        }

        while (j < b.Count)
        {
            merged.Add(b[j]);
            j++;
        }

        return merged;
    }

    static void Main()
    {
        var a = new List<int> { 1, 4, 7 };
        var b = new List<int> { 2, 3, 8 };

        var result = MergeSortedLists(a, b);

        Console.WriteLine(string.Join(", ", result));
    }
}
