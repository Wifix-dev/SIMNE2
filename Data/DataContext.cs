using Microsoft.EntityFrameworkCore;
using SIMNE2.Models;
namespace SIMNE2.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext>options):base(options){

        }
        public DbSet<Producto> Productos { get; set;}
    }
}