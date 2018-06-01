using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace MedicineShop.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationRole : IdentityRole
    {
        public ApplicationRole() : base() { }

        public ApplicationRole(string roleName): base(roleName) { }


    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<DueAmount> DueAmounts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<PrescriptionModel> PrescriptionModels { get; set; }
        public DbSet<CartOrder> CartOrders { get; set; }
        public DbSet<CartOrderDetails> CartOrderDetailses { get; set; }
        public DbSet<AdminMassage> AdminMassages { get; set; }
        public DbSet<CourierMessage> CourierMessages { get; set; }
        public DbSet<DeliveryManMessage> DeliveryManMessages { get; set; }


        public object CartOrderDetailss { get; internal set; }

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public System.Data.Entity.DbSet<MedicineShop.ViewModel.CourierViewModel> CourierViewModels { get; set; }

        
    }
}