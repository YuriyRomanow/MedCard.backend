using Microsoft.EntityFrameworkCore;
using MedCard.Application.Interfaces;
using MedCard.Persistence.EntityTypeConfigurations;
using MedCard.Domain;
namespace MedCard.Persistence;

public class MedCardDbContext : DbContext, IMedCardDbContext
{
    public DbSet<Domain.MedCard> MedCard { get; set; }

    public MedCardDbContext(DbContextOptions<MedCardDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfiguration(new MedCardConfiguration());
        base.OnModelCreating(builder);
    }
}