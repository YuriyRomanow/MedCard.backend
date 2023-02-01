using Microsoft.EntityFrameworkCore;

namespace MedCard.Application.Interfaces;

public interface IMedCardDbContext
{
    DbSet<Domain.MedCard.MedCard> MedCard { get; set; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}