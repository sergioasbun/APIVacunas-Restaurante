using Microsoft.EntityFrameworkCore;
using APIVacunas_Restaurante.Models;

namespace APIVacunas_Restaurante.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<APIVacunas_Restaurante.Models.Usuario> Usuario { get; set; }
        public DbSet<APIVacunas_Restaurante.Models.Vacuna> Vacuna { get; set; }
    }
}