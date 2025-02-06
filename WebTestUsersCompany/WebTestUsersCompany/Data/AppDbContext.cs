using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebTestUsersCompany.Models;
using WebTestUsersCompany.ViewModels;

namespace WebTestUsersCompany.Data
{
    public class AppDbContext : IdentityDbContext<Users>
    {
        public AppDbContext(DbContextOptions options) : base(options) 
        {
        }
        public DbSet<RoomBookingViewModel> RoomBookings { get; set; }
    }
}