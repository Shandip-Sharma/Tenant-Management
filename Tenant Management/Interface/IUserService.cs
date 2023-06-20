using Tenant_Management.Model;
using Tenant_Management.Model.ViewModel;
using Tenant_Management.Shared;

namespace Tenant_Management.Interface
{
    public interface IUserService
    {
        Task<IResult<string>> SaveUser(UserClass userRequest);
         Task<List<UserRequestModel>> getUser();

    }
}
