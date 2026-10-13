using Microsoft.EntityFrameworkCore;
using CBTSWE2_TP03.Models;

namespace CBTSWE2_TP03.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Produto> Produtos { get; set; }
    }
}