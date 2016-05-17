using System.Collections.Generic;

namespace CompaniesRelations.API.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AnnualEarnings { get; set; }


        /*
            int CalcEarnings(){
                int res = AnnualEarnings;
                foreach(var x in SubsidiaryCompanies)
                {
                    res += CalcEarnings(x);
                }
                return res;
            }

            */
        public List<Company> SubsidiaryCompanies { get; set; }
    }
}