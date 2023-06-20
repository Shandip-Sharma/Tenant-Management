using Microsoft.AspNetCore.Identity;
using Tenant_Management.Interface;
using Tenant_Management.Model;
using Tenant_Management.Model.ViewModel;
using Tenant_Management.Shared;

namespace Tenant_Management.Implementation
{
    public class UserService : IUserService
    {
        private readonly AppDbContext _appDbContext;
     //   private readonly UserManager<User> _userManager;
        public UserService(AppDbContext appDbContext)
        {
                _appDbContext = appDbContext;
          //  _userManager = userManager;
        }
        public async Task<List<UserRequestModel>> getUser()
        {
            
          var  userList = _appDbContext.userModel.ToList();
            return userList;
        }

        public async   Task<IResult<string>> SaveUser(UserClass userRequest)
        {
            User user = new User();
            user.FirstName = userRequest.FirstName;
            user.LastName = userRequest.LastName;
            user.UserName = userRequest.UserName;
            user.Email = userRequest.Email;
            user.UserType = userRequest.UserType;
            user.PhoneNumber = userRequest.PhoneNumber;
            if(userRequest.Password==userRequest.ConfirmPassword)
            {
                await _appDbContext.users.AddAsync(user);
                await _appDbContext.SaveChangesAsync();
              //  var result = await _userManager.CreateAsync(user, userRequest.Password);
            }
            
            return Result<string>.Success();
       }

      
    }
}
