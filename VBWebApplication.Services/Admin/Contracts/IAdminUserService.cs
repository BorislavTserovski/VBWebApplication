using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VBWebApplication.Services.Admin.Models;

namespace VBWebApplication.Services.Admin.Contracts
{
    public interface IAdminUserService
    {
        Task<IEnumerable<AdminListingServiceModel>> AllAsync();

        Task<AdminListingServiceModel> GetUserByIdAsync(string id);

        Task DeleteAsync(string id);
    }
}
