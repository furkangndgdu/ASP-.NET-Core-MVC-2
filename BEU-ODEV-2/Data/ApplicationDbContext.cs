using BEU_ODEV_2.Models;
using Microsoft.EntityFrameworkCore;

namespace BEU_ODEV_2.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }


        public DbSet<Users> Users { get; set; }
        public DbSet<Menus> Menus { get; set; }
        public DbSet<Contents> contents { get; set; }
    }
}
