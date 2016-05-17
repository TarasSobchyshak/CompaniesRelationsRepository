using System.Data.Entity;

namespace CompaniesRelations.DAL.Models
{
    public class CompanyContext : DbContext
    {
        public CompanyContext() : base("CompanyDB")
        {

        }
        public DbSet<Company> Companies { get; set; }
    }
}
