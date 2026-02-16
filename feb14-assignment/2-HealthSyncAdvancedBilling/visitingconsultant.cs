using System;

namespace HealthSyncBilling
{
    public class VisitingConsultant : Consultant
    {
        public int ConsultationsCount { get; set; }
        public double RatePerVisit { get; set; }

        public VisitingConsultant(string id, int visits, double rate)
            : base(id)
        {
            ConsultationsCount = visits;
            RatePerVisit = rate;
        }

        public override double CalculateGrossPayout()
        {
            return ConsultationsCount * RatePerVisit;
        }
        public override double CalculateTDS(double gross)
        {
            return 0.10;
        }
    }
}
