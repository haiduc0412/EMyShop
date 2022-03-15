using EMyShop.ViewModel.Common;
using EMyShop.ViewModel.System.User;
using System;
using System.Threading.Tasks;

namespace EMyShop.ApiIntegration
{
    public interface IUserApiClient
    {
        Task<APIResult<string>> Authencate(LoginRequest request);

        Task<APIResult<PageResult<UserVM>>> GetUsersPagings(GetUserPagingRequest request);

        Task<APIResult<bool>> RegisterUser(RegisterRequest registerRequest);

        Task<APIResult<bool>> UpdateUser(Guid id, UserUpdateRequest request);

        Task<APIResult<UserVM>> GetById(Guid id);

        Task<APIResult<bool>> Delete(Guid id);

        Task<APIResult<bool>> RoleAssign(Guid id, RoleAssignRequest request);
    }
}
