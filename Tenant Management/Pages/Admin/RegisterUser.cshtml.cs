using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Tenant_Management.Pages.Admin
{
    public class RegisterUserModel : PageModel
    {
        public void OnGet()
        {
            ViewData["PageName"] = "Register";

        }
    }
}
