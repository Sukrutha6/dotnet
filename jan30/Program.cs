using System;

namespace test1
{
	public class Student
	{
		public string? Name { get; set; }
		public int Marks { get; set; }
	}

	public class Predicatee
	{


		public static void Main()
		{
			Student s = new Student();

			s.Name = "A";
			s.Marks = 89;

			
			Predicate<int> result = m=>m>80;
			Func<int, double> percent=m=>m*1.0;;
			Action<string> show=msg=>Console.WriteLine(msg);
			show($"The student {percent(s.Marks)}");
			show($"Percentage: {result(s.Marks)}%");

		}
	}
}