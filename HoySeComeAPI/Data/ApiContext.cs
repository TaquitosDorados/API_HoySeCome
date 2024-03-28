using Microsoft.EntityFrameworkCore;
using HoySeComeAPI.Models;

namespace HoySeComeAPI.Data
{
    public class ApiContext : DbContext
    {
        public DbSet<Ingredientes> Ingredientes { get; set; }
        public ApiContext(DbContextOptions<ApiContext> options)
            : base(options)
        {

        }
    }
}
