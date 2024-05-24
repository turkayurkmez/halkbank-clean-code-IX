using CleanCode.Application;
using CleanCode.Models;

namespace CleanCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var timeSheetEntries = getTimeSheetEntriesFromUser();
            var billService = new BillService(timeSheetEntries);
            billService.CalculateBillAndSendEmail();

            var extra = billService.getExtraPayment();
            Console.WriteLine("You will get paid $" + extra + " for your work.");
            Console.WriteLine();
            Console.Write("Press any key to exit application...");
            Console.ReadKey();
        }

        static List<TimeSheetEntry> getTimeSheetEntriesFromUser()
        {

            var answer = string.Empty;
            List<TimeSheetEntry> timeSheetEntries = new List<TimeSheetEntry>();
            do
            {
                Console.Write("Enter what you did: ");
                string workDescription = Console.ReadLine();
                double timeForWork = getTimeForWork();
                TimeSheetEntry timeSheetEntry = new TimeSheetEntry
                {
                    HoursWorked = timeForWork,
                    WorkDone = workDescription
                };
                timeSheetEntries.Add(timeSheetEntry);

                Console.Write("Do you want to enter more time (yes/no): ");
                answer = Console.ReadLine();

            } while (answer.ToLower() == UserAnwers.YES);

            return timeSheetEntries;
        }

        static double getTimeForWork()
        {

            double timeForWork = 0;
            var isParsed = true;
            do
            {
                Console.Write("How long did you do it for: ");

                string rawTimeWorked = Console.ReadLine();
                isParsed = double.TryParse(rawTimeWorked, out timeForWork);
                if (!isParsed)
                {
                    Console.WriteLine("Invalid number given");
                }

            } while (!isParsed);

            return timeForWork;
        }

    }
}
