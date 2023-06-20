using Microsoft.EntityFrameworkCore;
using Tenant_Management.Model;
using Tenant_Management.Model.ViewModel;
using Tenant_Management.Pages.Admin;

namespace Tenant_Management
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {                
        }
        public DbSet<User>users { get; set; }
        public DbSet<UserTypes> userTypes { get; set; }
        public DbSet<UserRequestModel> userModel { get; set; }
    }
}
