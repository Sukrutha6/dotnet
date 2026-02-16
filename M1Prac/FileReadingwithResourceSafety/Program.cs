using System;
class Program
{
    static void Main()
    {
        string filePath = "data.txt";
        try
        {
            FileService.ReadFile(filePath);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected error: {ex.Message}");
        }
    }
}