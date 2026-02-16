// using System;
// using PracticeSessions;
// namespace PracticeSessions
// {
//     public delegate void Notify();
//     public class Student : IComparable<Student>
//     {
//         public string Name { get; set; }
//         public int Marks { get; set; }

//         {
//             Console.WriteLine("Good Student");
//         }

//         public void AverageStudent()
//         {
//             Console.WriteLine("Average Student");
//         }

//         public void SendNotification(Student s)
//         {
//             OnNotify = null;

//             if (s.Marks <= 500)
//             {
//                 OnNotify = NeedImpovement;
//             }
//             else if (s.Marks >= 560)
//             {
//                 OnNotify = GoodStudent;
//             }
//             else
//             {
//                 OnNotify = AverageStudent;
//             }
//             OnNotify?.Invoke();
//         }
//     }
//     public class Program
//     {
//         static void Main(string[] args)
//         {
//             Student s = new Student();
//             List<Student> students = new List<Student>();
//             students.Add(new Student
//             {
//                 Name = "Sukrutha",
//                 Marks = 500
//             });
//             students.Add(new Student
//             {
//                 Name = "Karthik",
//                 Marks = 450
//             });
//             students.Add(new Student
//             {
//                 Name = "Sukku",
//                 Marks = 550
//             });
//             students.Add(new Student
//             {
//                 Name = "Honey",
//                 Marks = 600
//             });
//             students.Add(new Student
//             {
//                 Name = "Puttu",
//                 Marks = 560
//             });
//             students.Sort();
//             int rank = 1;
//             foreach(Student student in students)
//             {
//                 Console.Write($"Rank = {rank++} Name = {student.Name}, Marks = {student.Marks}, Remarks: ");
//                 s.SendNotification(student);
//                 Console.WriteLine();
//             }
//         }
//     }
// }