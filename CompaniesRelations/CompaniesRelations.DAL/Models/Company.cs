using System.Collections.Generic;

namespace CompaniesRelations.DAL.Models
{
    public class Company
    {
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public int Earnings { get; set; }

        public virtual List<Company> SubsidiaryCompanies { get; set; }
    }
}
