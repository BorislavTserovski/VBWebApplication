using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VBApp.Data;
using VBWebApplication.Services.Admin.Contracts;
using VBWebApplication.Services.Admin.Models;

namespace VBWebApplication.Services.Admin.Implementations
{
    public class AdminUserService : IAdminUserService
    {
        private readonly VBWebApplicationDbContext db;

        public AdminUserService(VBWebApplicationDbContext db)
        {
            this.db = db;
        }

        public async Task<IEnumerable<AdminListingServiceModel>> AllAsync()
        => await this.db
            .Users
            .ProjectTo<AdminListingServiceModel>()
            .ToListAsync();

        public async Task DeleteAsync(string id)
        {
            var user = this.db.Users.Where(u => u.Id == id).FirstOrDefault();
            if (user == null)
            {
                return;
            }
            this.db.Users.Remove(user);

            await this.db.SaveChangesAsync();
        }

        public async Task<AdminListingServiceModel> GetUserByIdAsync(string id)
        {
            var result = await this.db.Users.Where(u => u.Id == id)
                .ProjectTo<AdminListingServiceModel>()
                .FirstOrDefaultAsync();

            return result;
        }
    }
}
