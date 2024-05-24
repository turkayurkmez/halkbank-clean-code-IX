using CleanCode.Models;

namespace CleanCode.Application
{
    public class BillService
    {
        BillCalculator billCalculator = new BillCalculator();
        private readonly List<TimeSheetEntry> timeSheetEntries;

        public BillService(List<TimeSheetEntry> timeSheetEntries)
        {
            this.timeSheetEntries = timeSheetEntries;
        }

        public void CalculateBillAndSendEmail()
        {
            var companies = new CompanyService().GetCompanies();
            MailSimulator mailSimulator = new MailSimulator(billCalculator);
            mailSimulator.SimulateEmail(companies, timeSheetEntries);
        }

        public double getExtraPayment()
        {
            var extra = billCalculator.GetExtraPaymentForWork(timeSheetEntries, maxHourInAWeek: 40, normalPayment: 10, extraPayment: 15);
            return extra;
        }
    }
}
