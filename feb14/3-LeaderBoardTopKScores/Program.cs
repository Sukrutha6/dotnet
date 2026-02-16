using System;
class Program
{
    static List<(string name, int score)> GetTopK(
        List<(string name, int score)> players, int k)
    {
        return players
            .OrderByDescending(p => p.score)   
            .ThenBy(p => p.name)               
            .Take(k)                           
            .ToList();
    }

    static void Main()
    {
        var players = new List<(string name, int score)>
        {
            ("Sukrutha", 80),
            ("Karthik", 95),
            ("Sukku", 95),
            ("Puttu", 70)
        };

        int k = 3;

        var topK = GetTopK(players, k);

        foreach (var player in topK)
        {
            Console.WriteLine($"{player.name}: {player.score}");
        }
    }
}
