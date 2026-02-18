using System;
using CampusHireApp.Models;
using CampusHireApp.Services;

namespace CampusHireApp
{
    public class Program
    {
        static void Main()
        {
            ApplicantService service = new ApplicantService();

            while (true)
            {
                Console.WriteLine("\n===== CampusHire =====");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Display All");
                Console.WriteLine("3. Search");
                Console.WriteLine("4. Delete");
                Console.WriteLine("5. Exit");
                Console.Write("Choose: ");

                string? choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddApplicant(service);
                        break;
                    case "2":
                        foreach (var a in service.GetAll())
                            Console.WriteLine($"{a.ApplicantId} - {a.Name}");
                        break;
                    case "3":
                        Console.Write("Enter ID: ");
                        var id = Console.ReadLine();
                        var applicant = service.GetById(id!);
                        Console.WriteLine(applicant != null
                            ? $"{applicant.Name} - {applicant.CoreCompetency}"
                            : "Not Found");
                        break;
                    case "4":
                        Console.Write("Enter ID: ");
                        service.Delete(Console.ReadLine()!);
                        break;
                    case "5":
                        return;
                }
            }
        }

        static void AddApplicant(ApplicantService service)
        {
            try
            {
                Applicant a = new Applicant();

                Console.Write("ID: ");
                a.ApplicantId = ValidationService.ValidateApplicantId(Console.ReadLine());

                Console.Write("Name: ");
                a.Name = ValidationService.ValidateName(Console.ReadLine());

                Console.Write("Current Location: ");
                a.CurrentLocation = ValidationService.ValidateCurrentLocation(Console.ReadLine());

                Console.Write("Preferred Location: ");
                a.PreferredLocation = ValidationService.ValidatePreferredLocation(Console.ReadLine());

                Console.Write("Competency: ");
                a.CoreCompetency = ValidationService.ValidateCompetency(Console.ReadLine());

                Console.Write("Passing Year: ");
                a.PassingYear = ValidationService.ValidatePassingYear(Console.ReadLine());

                service.Add(a);

                Console.WriteLine("Applicant added successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
