using Microsoft.EntityFrameworkCore;
using Pizza_web.Model;

namespace Pizza_web.Data
{
    public class ApplicationDBContext:DbContext
    {
        public DbSet<pizzaorder> pizzaorders { get; set; }
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext>options):base(options)
        {

        }
    }
}
