using Microsoft.EntityFrameworkCore;
using WebASPNET_API_Lesson4.Models;

namespace WebASPNET_API_Lesson4.Context
{
    public class ApplicationDbContext :DbContext
    {
        public DbSet<Car> Cars { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) : base(option)
        {

        }
    }
}
