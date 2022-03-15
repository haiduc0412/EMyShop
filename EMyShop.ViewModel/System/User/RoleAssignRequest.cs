using EMyShop.ViewModel.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMyShop.ViewModel.System.User
{
    public class RoleAssignRequest
    {
        public Guid Id { get; set; }
        public List<SelectItems> Roles { get; set; } = new List<SelectItems>();
    }
}
