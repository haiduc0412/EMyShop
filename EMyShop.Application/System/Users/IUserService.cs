using System;
using System.Collections.Generic;
using EMyShop.ViewModel.System.User;
using System.Text;
using System.Threading.Tasks;
using EMyShop.ViewModel.Common;

namespace EMyShop.Application.System.Users
{
    public interface IUserService
    {
        Task<APIResult<string>> Authencate(LoginRequest request);

        Task<APIResult<bool>> Register(RegisterRequest request);

        Task<APIResult<bool>> Update(int id, UserUpdateRequest request);

        Task<APIResult<PageResult<UserVM>>> GetUsersPaging(GetUserPagingRequest request);

        Task<APIResult<UserVM>> GetById(int id);

        Task<APIResult<bool>> Delete(int id);

        Task<APIResult<bool>> RoleAssign(int id, RoleAssignRequest request);
    }
}
