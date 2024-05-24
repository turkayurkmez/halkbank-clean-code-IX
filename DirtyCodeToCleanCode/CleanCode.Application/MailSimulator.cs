using CleanCode.Models;

namespace CleanCode.Application
{
    public class MailSimulator
    {

        private readonly BillCalculator calculator;

        public MailSimulator(BillCalculator calculator)
        {
            this.calculator = calculator;
        }

        public void SimulateEmail(List<Company> companies, List<TimeSheetEntry> timeSheetEntries)
        {
            companies.ForEach(company =>
            {
                var bill = calculator.GetBillForCompany(company, timeSheetEntries);
                Console.WriteLine("Simulating Sending email to " + company.Name);
                Console.WriteLine("Your bill is $" + bill + " for the hours worked.");
            });


        }



    }
}
