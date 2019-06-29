using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ByYsmn.Application.CompanyServices.Dtos;
using ByYsmn.Application.Shared;
using ByYsmn.Core.Companies;
using ByYsmn.Entityframework.Contexts;

namespace ByYsmn.Application.CompanyServices
{
    public class CompanyService : ICompanyService
    {
        private readonly ApplicationDbContext _context;
        public CompanyService(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task<Company> Get(EntityInput<Guid> input)
        {
            throw new NotImplementedException();
        }

        public Task<List<Company>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<List<Company>> GetAllByKeyWord(string input)
        {
            throw new NotImplementedException();
        }

        public Task<List<Company>> GetAllByUserId(Guid userId)
        {
            throw new NotImplementedException();
        }

        public async Task<Company> Create(CompanyCreateInput input)
        {
            var company = Company.Create(input.Name, input.Tel, input.Address, input.WebSiteUrl, input.Email, input.CreatorUserId);
            await _context.Companies.AddAsync(company);
            await _context.SaveChangesAsync();
            return company;
        }
        public Task<Company> Update(CompanyUpdateInput input)
        {
            throw new NotImplementedException();
        }
        public Task<bool> Delete(EntityInput<Guid> input)
        {
            throw new NotImplementedException();
        }
    }
}
