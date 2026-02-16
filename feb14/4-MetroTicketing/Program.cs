using System;
class Program
{
    static int CountPeakRegularTickets(
        Queue<(TimeSpan entryTime, string ticketType)> q)
    {
        int count = 0;

        TimeSpan peakStart = new TimeSpan(8, 0, 0);  
        TimeSpan peakEnd = new TimeSpan(10, 0, 0);   

        while (q.Count > 0)
        {
            var passenger = q.Dequeue();

            if (passenger.ticketType == "Regular" &&
                passenger.entryTime >= peakStart &&
                passenger.entryTime <= peakEnd)
            {
                count++;
            }
        }

        return count;
    }

    static void Main()
    {
        var q = new Queue<(TimeSpan, string)>();
        q.Enqueue((new TimeSpan(8, 30, 0), "Regular"));
        q.Enqueue((new TimeSpan(9, 15, 0), "Premium"));
        q.Enqueue((new TimeSpan(10, 0, 0), "Regular"));
        q.Enqueue((new TimeSpan(7, 45, 0), "Regular"));
        q.Enqueue((new TimeSpan(9, 45, 0), "Regular"));

        int result = CountPeakRegularTickets(q);

        Console.WriteLine($"Peak Regular Tickets: {result}");
    }
}
