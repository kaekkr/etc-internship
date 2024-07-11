using ETC_internship.Models;
using Microsoft.EntityFrameworkCore;

namespace ETC_internship.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions dbContextOptions)
            : base(dbContextOptions)
        {

        }

        public DbSet<User> Users { get; set; }
    }
}
