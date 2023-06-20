using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Tenant_Management.Model
{
    public class User:IdentityUser
    {     
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int UserType { get; set; }
       
        
    }  
}
