using System;
using System.Collections.Generic;
using CampusHireApp.Models;
using CampusHireApp.Utilities;

namespace CampusHireApp.Services
{
    public class ApplicantService
    {
        private List<Applicant> applicants;

        public ApplicantService()
        {
            applicants = FileService.Load();
        }

        public void Add(Applicant applicant)
        {
            applicants.Add(applicant);
            FileService.Save(applicants);
        }

        public List<Applicant> GetAll() => applicants;

        public Applicant? GetById(string id)
        {
            return applicants.Find(a => a.ApplicantId == id);
        }

        public void Delete(string id)
        {
            var applicant = GetById(id);
            if (applicant != null)
            {
                applicants.Remove(applicant);
                FileService.Save(applicants);
            }
        }

        public void Update(Applicant updated)
        {
            var existing = GetById(updated.ApplicantId);
            if (existing != null)
            {
                existing.Name = updated.Name;
                existing.PreferredLocation = updated.PreferredLocation;
                existing.CoreCompetency = updated.CoreCompetency;
                existing.PassingYear = updated.PassingYear;
                FileService.Save(applicants);
            }
        }
    }
}
