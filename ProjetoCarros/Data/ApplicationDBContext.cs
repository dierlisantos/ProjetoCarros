using Microsoft.EntityFrameworkCore;
using ProjetoCarros.Models;

namespace ProjetoCarros.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        public DbSet<RegistoModel> RegistosCarros { get; set; }
    }


}
