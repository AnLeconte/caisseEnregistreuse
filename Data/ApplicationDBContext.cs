using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Produit> Produits { get; set; }
    public DbSet<Categorie> Categories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Produit>()
            .Property(p => p.Prix)
            .HasColumnType("decimal(18,2)"); 

        base.OnModelCreating(modelBuilder);
    }
}
