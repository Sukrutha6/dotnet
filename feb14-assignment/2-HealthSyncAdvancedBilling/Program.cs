using System;

namespace HealthSyncBilling
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter Consultant Type (1-InHouse / 2-Visiting):");
            int type = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Consultant ID:");
            string id = Console.ReadLine();

            Consultant consultant = null;

            if (type == 1)
            {
                Console.WriteLine("Enter Monthly Stipend:");
                double stipend = double.Parse(Console.ReadLine());

                consultant = new InHouseConsultant(id, stipend);
            }
            else if (type == 2)
            {
                Console.WriteLine("Enter Number of Visits:");
                int visits = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Rate Per Visit:");
                double rate = double.Parse(Console.ReadLine());

                consultant = new VisitingConsultant(id, visits, rate);
            }
            else
            {
                Console.WriteLine("Invalid consultant type");
                return;
            }

            consultant.DisplayPayout();
        }
    }
}
