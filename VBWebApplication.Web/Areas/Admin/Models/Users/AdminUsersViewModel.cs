using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VBWebApplication.Services.Admin.Models;

namespace VBWebApplication.Web.Areas.Admin.Models.Users
{
    public class AdminUsersViewModel
    {
        public IEnumerable<SelectListItem> Roles { get; set; }

        public IEnumerable<AdminListingServiceModel> Users { get; set; }
    }
}
