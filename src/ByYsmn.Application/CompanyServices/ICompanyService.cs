using ByYsmn.Application.CompanyServices.Dtos;
using ByYsmn.Application.Shared;
using ByYsmn.Core.Companies;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ByYsmn.Application.CompanyServices
{
    public interface ICompanyService 
        : IBaseService<Guid, CompanyCreateInput, CompanyUpdateInput, Company>
    {
    }
}
