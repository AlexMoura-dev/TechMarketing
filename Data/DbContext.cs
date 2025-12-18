using Microsoft.EntityFrameworkCore;
using TechMarketing.Models;

namespace TechMarketing.Data; 

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }

    public DbSet<ClienteModel> Clientes { get; set; }
    public DbSet<PersonModel> Pessoas { get; set; }
    public DbSet<VendaModel> Vendas { get; set; }

}
