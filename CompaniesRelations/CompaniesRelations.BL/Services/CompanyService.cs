using CompaniesRelations.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompaniesRelations.BL.Services
{
    public class CompanyService
    {
        public void AddCompany(Company company)
        {
            using (var context = new CompanyContext())
            {
                context.Companies.Add(company);
                context.SaveChanges();
            };
        }
        public void AddCompanies(params Company[] company)
        {
            using (var context = new CompanyContext())
            {
                context.Companies.AddRange(company);
                context.SaveChanges();
            };
        }
        public Company GetCompany(int id)
        {
            Company temp;
            using (var context = new CompanyContext())
            {
                temp = context.Companies.Where(c => c.CompanyId == id).SingleOrDefault();
            };
            return temp;
        }
        public void DeleteCompany(int id)
        {
            Company company = new Company { CompanyId = id };
            using (var context = new CompanyContext())
            {
                context.Companies.Attach(company);
                context.Companies.Remove(company);
                context.SaveChanges();
            };
        }
        public void UpdateCompany(int id, Company company)
        {
            Company target;
            using (var context = new CompanyContext())
            {
                target = context.Companies.Where(c => c.CompanyId == id).SingleOrDefault();

                target.Earnings = company.Earnings;
                target.Name = company.Name;
                target.SubsidiaryCompanies = company.SubsidiaryCompanies;

                context.SaveChanges();
            };
        }
    }
}
