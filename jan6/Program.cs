// using System;
// using System.Xml.Serialization;

// public class clsPerson
// {
//     public string FirstName { get; set; } = string.Empty;
//     public string MI { get; set; } = string.Empty;
//     public string LastName { get; set; } = string.Empty;
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         clsPerson p = new clsPerson
//         {
//             FirstName = "Jeff",
//             MI = "A",
//             LastName = "Price"
//         };

//         XmlSerializer serializer = new XmlSerializer(typeof(clsPerson));
//         serializer.Serialize(Console.Out, p);

//         Console.WriteLine();
//         Console.ReadLine();
//     }
// }
