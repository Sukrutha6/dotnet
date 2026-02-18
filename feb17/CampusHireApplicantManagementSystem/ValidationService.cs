using System;
namespace CampusHireApp.Services
{
    public static class ValidationService
    {
        public static string ValidateApplicantId(string? input)
        {
            if (string.IsNullOrWhiteSpace(input))
                throw new Exception("Applicant ID is mandatory.");

            if (input.Length != 8 || !input.StartsWith("CH"))
                throw new Exception("Applicant ID must be 8 characters and start with 'CH'.");

            return input;
        }

        public static string ValidateName(string? input)
        {
            if (string.IsNullOrWhiteSpace(input))
                throw new Exception("Name is mandatory.");

            if (input.Length < 4 || input.Length > 15)
                throw new Exception("Name must be between 4 and 15 characters.");

            return input;
        }

        public static string ValidateCurrentLocation(string? input)
        {
            string[] allowed = { "Mumbai", "Pune", "Chennai" };
            if (Array.IndexOf(allowed, input) < 0)
                throw new Exception("Invalid current location.");
            return input!;
        }

        public static string ValidatePreferredLocation(string? input)
        {
            string[] allowed = { "Mumbai", "Pune", "Chennai", "Delhi", "Kolkata", "Bangalore" };
            if (Array.IndexOf(allowed, input) < 0)
                throw new Exception("Invalid preferred location.");
            return input!;
        }

        public static string ValidateCompetency(string? input)
        {
            string[] allowed = { ".NET", "JAVA", "ORACLE", "Testing" };
            if (Array.IndexOf(allowed, input) < 0)
                throw new Exception("Invalid core competency.");
            return input!;
        }

        public static int ValidatePassingYear(string? input)
        {
            if (!int.TryParse(input, out int year))
                throw new Exception("Invalid year format.");

            if (year > DateTime.Now.Year)
                throw new Exception("Passing year cannot be greater than current year.");

            return year;
        }
    }
}
