using EMyShop.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using EMyShop.ViewModel.System.User;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using EMyShop.ViewModel.Common;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace EMyShop.Application.System.Users
{
    public class UserService : IUserService
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly RoleManager<Role> _roleManager;
        private readonly IConfiguration _config;
        public UserService(UserManager<User> userManager,
            SignInManager<User> signInManager,
            RoleManager<Role> roleManager,
            IConfiguration config)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _config = config;
        }

        public async Task<APIResult<string>> Authencate(LoginRequest request)
        {
            var user = await _userManager.FindByNameAsync(request.UserName);
            if (user == null) return new APIErrorResult<string>("Tài khoản không tồn tại");

            var result = await _signInManager.PasswordSignInAsync(user, request.Password, request.RememberMe, true);
            if (!result.Succeeded)
            {
                return new APIErrorResult<string>("Đăng nhập không đúng");
            }
            var roles = await _userManager.GetRolesAsync(user);
            var claims = new[]
            {
                new Claim(ClaimTypes.Email,user.Email),
                new Claim(ClaimTypes.GivenName,user.Fullname),
            };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Tokens:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(_config["Tokens:Issuer"],
                _config["Tokens:Issuer"],
                claims,
                expires: DateTime.Now.AddHours(3),
                signingCredentials: creds);

            return new APISuccessResult<string>(new JwtSecurityTokenHandler().WriteToken(token));
        }

        public async Task<APIResult<bool>> Delete(int id)
        {
            var user = await _userManager.FindByIdAsync(id.ToString());
            if (user == null)
            {
                return new APIErrorResult<bool>("User không tồn tại");
            }
            var result = await _userManager.DeleteAsync(user);
            if (result.Succeeded)
                return new APISuccessResult<bool>();

            return new APIErrorResult<bool>("Xóa không thành công");
        }

        public async Task<APIResult<UserVM>> GetById(int id)
        {
            var user = await _userManager.FindByIdAsync(id.ToString());
            if (user == null)
            {
                return new APIErrorResult<UserVM>("User không tồn tại");
            }
            var roles = await _userManager.GetRolesAsync(user);
            var userVm = new UserVM()
            {
                Email = user.Email,
                PhoneNumber = user.Phone,
                FullName = user.Fullname,
                UserId = user.UserID,
                UserName = user.UserName,
                Roles = roles
            };
            return new APISuccessResult<UserVM>(userVm);
        }

        public async Task<APIResult<PageResult<UserVM>>> GetUsersPaging(GetUserPagingRequest request)
        {
            var query = _userManager.Users;
            if (!string.IsNullOrEmpty(request.Keyword))
            {
                query = query.Where(x => x.UserName.Contains(request.Keyword)
                 || x.Phone.Contains(request.Keyword));
            }
            int totalRow = await query.CountAsync();

            var data = await query.Skip((request.PageIndex - 1) * request.PageSize)
                .Take(request.PageSize)
                .Select(x => new UserVM()
                {
                    Email = x.Email,
                    PhoneNumber = x.Phone,
                    UserName = x.UserName,
                    FullName = x.Fullname,
                    UserId = x.UserID,

                }).ToListAsync();

            //4. Select and projection
            var pagedResult = new PageResult<UserVM>()
            {
                TotalRecord = totalRow,
                PageIndex = request.PageIndex,
                PageSize = request.PageSize,
                Items = data
            };
            return new APISuccessResult<PageResult<UserVM>>(pagedResult);
        }

        public async Task<APIResult<bool>> Register(RegisterRequest request)
        {
            var user = await _userManager.FindByNameAsync(request.UserName);
            if (user != null)
            {
                return new APIErrorResult<bool>("Tài khoản đã tồn tại");
            }
            if (await _userManager.FindByEmailAsync(request.Email) != null)
            {
                return new APIErrorResult<bool>("Emai đã tồn tại");
            }

            user = new User()
            {
                Email = request.Email,
                Fullname = request.FullName,
                UserName = request.UserName,
                Phone = request.PhoneNumber
            };
            var result = await _userManager.CreateAsync(user, request.Password);
            if (result.Succeeded)
            {
                return new APISuccessResult<bool>();
            }
            return new APIErrorResult<bool>("Đăng ký không thành công");
        }

        public async Task<APIResult<bool>> RoleAssign(int id, RoleAssignRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<APIResult<bool>> RoleAssign(Guid id, RoleAssignRequest request)
        {
            throw new NotImplementedException();
        }

        public async Task<APIResult<bool>> Update(int id, UserUpdateRequest request)
        {
            if (await _userManager.Users.AnyAsync(x => x.Email == request.Email && x.UserID != id))
            {
                return new APIErrorResult<bool>("Emai đã tồn tại");
            }
            var user = await _userManager.FindByIdAsync(id.ToString());
            user.Email = request.Email;
            user.Fullname = request.FullName;
            user.Phone = request.PhoneNumber;

            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return new APISuccessResult<bool>();
            }
            return new APIErrorResult<bool>("Cập nhật không thành công");
        }
    }
}
