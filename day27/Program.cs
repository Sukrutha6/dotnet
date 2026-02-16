using ExamSchedule.Model;
using ExamSchedule.Data;

public class Program{
    public static void Main(string[] args)
    {
        var localStudents = DataBank.GetStudents();

        Console.Write($"\nStudent Names: ");
        foreach(var s in localStudents)
        {
            Console.Write($"{s.Name} | ");
        }
    }
}