using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;
using Tenant_Management.Interface;
using Tenant_Management.Model;
using Tenant_Management.Model.ViewModel;

namespace Tenant_Management.Pages
{
    public class UserModel : PageModel
    {
        private readonly IUserService _userService;
        private readonly AppDbContext _appDbContext;
        public UserModel(IUserService userService,AppDbContext appDbContext)
        {
                _userService = userService;
            _appDbContext = appDbContext;
        }
        [BindProperty]
        public UserClass userRequest { get; set; }
        public List<UserRequestModel> userList { get; set; } = new List<UserRequestModel>();  



        public async void OnGet()
        {           
            ViewData["PageName"] = "User";
          userList=  await getAllUser();
       
        }
        public Task<List<UserRequestModel>> getAllUser()
        {
            var  userList=  _userService.getUser();
            return userList;
        }
        public  async Task Onpostasync()
        {

         var result=   await _userService.SaveUser(userRequest);
        if(result.Succeeded)
            {
                
            }
        }
       
    }
}
