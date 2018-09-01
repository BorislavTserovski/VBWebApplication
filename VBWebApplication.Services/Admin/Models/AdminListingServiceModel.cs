using System;
using System.Collections.Generic;
using System.Text;
using VBWebApplication.Common.Mapping;
using VBWebApplication.Data.Models;

namespace VBWebApplication.Services.Admin.Models
{
    public class AdminListingServiceModel : IMapFrom<User>
    {
        public string Id { get; set; }

        public string Username { get; set; }

        public string Email { get; set; }
    }
}
