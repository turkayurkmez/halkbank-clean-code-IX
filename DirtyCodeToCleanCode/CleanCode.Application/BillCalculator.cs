using CleanCode.Models;

namespace CleanCode.Application
{
    public class BillCalculator
    {
        public double GetBillForCompany(Company company, List<TimeSheetEntry> timeSheetEntries)
        {
            double totalHoursOnAWeek = timeSheetEntries.Where(ts => ts.WorkDone.ToLower().Contains(company.Name.ToLower()))
                                                       .Sum(ts => ts.HoursWorked);

            return totalHoursOnAWeek * company.HourlyPrice;
        }

        public double GetExtraPaymentForWork(List<TimeSheetEntry> timeSheetEntries, double maxHourInAWeek, double normalPayment, double extraPayment)
        {
            double totalHoursInAWeek = timeSheetEntries.Sum(ts => ts.HoursWorked);
            var totalPriceForExtra = 0.0;

            if (totalHoursInAWeek < maxHourInAWeek)
            {
                totalPriceForExtra = totalHoursInAWeek * normalPayment;
            }
            else
            {
                var standard = maxHourInAWeek * normalPayment;
                var moreThanMax = (totalHoursInAWeek - maxHourInAWeek) * extraPayment;
                totalPriceForExtra = moreThanMax + standard;
            }



            return totalPriceForExtra;
        }
    }
}
