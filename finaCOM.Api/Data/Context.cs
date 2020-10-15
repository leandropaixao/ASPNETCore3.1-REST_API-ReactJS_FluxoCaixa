using finaCOM.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace finaCOM.Api.Data
{
    public class Context: DbContext
    {
        public DbSet<Conta> Contas { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;port=3306;database=finaCOM;uid=user;password=user");
        }
    }
}