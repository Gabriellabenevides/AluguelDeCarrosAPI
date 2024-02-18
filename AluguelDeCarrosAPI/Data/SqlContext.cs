using AluguelDeCarrosAPI.Model;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace AluguelDeCarrosAPI.Data
{
    public class SqlContext : DbContext
    {
        public SqlContext(DbContextOptions<SqlContext> opts) : base(opts)
        {

        }

        public DbSet<Carro> Carros { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<ApplicationUser> User { get; set; }
    }
}
