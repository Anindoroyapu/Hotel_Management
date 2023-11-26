using Microsoft.EntityFrameworkCore;

namespace HotelManagement.Models
{
    public class SignupContext : DbContext
    {
        public DbSet<Signup> FirstName { get; set; }
      
        public SignupContext(DbContextOptions options)
        {
            
        }
    }
}
