using System;

namespace HealthSyncBilling
{
    public abstract class Consultant
    {
        public string ConsultantId { get; set; }

        protected Consultant(string consultantId)
        {
            if (!ValidateConsultantId(consultantId))
            {
                Console.WriteLine("Invalid doctor id");
                Environment.Exit(0);
            }

            ConsultantId = consultantId;
        }

        public abstract double CalculateGrossPayout();

        public virtual double CalculateTDS(double gross)
        {
            if (gross <= 5000)
                return 0.05;
            else
                return 0.15;
        }

        public void DisplayPayout()
        {
            double gross = CalculateGrossPayout();
            double taxRate = CalculateTDS(gross);
            double net = gross - (gross * taxRate);

            Console.WriteLine($"Gross: {gross:F2} | TDS Applied: {taxRate * 100}% | Net Payout: {net:F2}");
        }

        public static bool ValidateConsultantId(string id)
        {
            if (id.Length != 6)
                return false;

            if (!id.StartsWith("DR"))
                return false;

            for (int i = 2; i < 6; i++)
            {
                if (!char.IsDigit(id[i]))
                    return false;
            }

            return true;
        }
    }
}
