using Microsoft.EntityFrameworkCore;

namespace APIVacunas_Restaurante
{
    class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
    }
}