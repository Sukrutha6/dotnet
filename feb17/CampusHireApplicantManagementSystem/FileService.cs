using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using CampusHireApp.Models;
namespace CampusHireApp.Utilities
{
    public static class FileService
    {
        private const string FilePath = "applicants.json";

        public static void Save(List<Applicant> applicants)
        {
            var json = JsonSerializer.Serialize(applicants);
            File.WriteAllText(FilePath, json);
        }

        public static List<Applicant> Load()
        {
            if (!File.Exists(FilePath))
                return new List<Applicant>();

            var json = File.ReadAllText(FilePath);
            return JsonSerializer.Deserialize<List<Applicant>>(json)
                   ?? new List<Applicant>();
        }
    }
}
