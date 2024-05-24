using CleanCode.Models;

namespace CleanCode.Application
{
    public class CompanyService
    {
        public List<Company> GetCompanies()
        {
            return new List<Company>()
            {
                new Company{ Name = "Acme", HourlyPrice=150},
                new Company{ Name = "ABC", HourlyPrice=125},

            };
        }
    }
}
