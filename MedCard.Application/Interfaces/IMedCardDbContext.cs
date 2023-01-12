using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MedCard.Domain;

namespace MedCard.Application.Interfaces;

public interface IMedCardDbContext
{
    DbSet<Domain.MedCard> MedCard { get; set; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}