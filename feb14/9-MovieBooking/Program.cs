using System;


class Program
{
    static List<int> AllocateSeats(int n, List<int> alreadyBooked, int requestCount)
    {

        SortedSet<int> availableSeats = new SortedSet<int>();
        for (int i = 1; i <= n; i++)
        {
            availableSeats.Add(i);
        }

        foreach (int seat in alreadyBooked)
        {
            availableSeats.Remove(seat);
        }

        List<int> allocatedSeats = new List<int>();

        for (int i = 0; i < requestCount; i++)
        {
            if (availableSeats.Count > 0)
            {
                int seatToAllocate = availableSeats.Min; 
                allocatedSeats.Add(seatToAllocate);
                availableSeats.Remove(seatToAllocate);
            }
            else
            {
                allocatedSeats.Add(-1); 
            }
        }

        return allocatedSeats;
    }

    static void Main()
    {
        int n = 5;
        var alreadyBooked = new List<int> { 2, 4 };
        int requestCount = 5;

        var result = AllocateSeats(n, alreadyBooked, requestCount);

        Console.WriteLine(string.Join(", ", result));
    }
}

