using MedCard.Application.Interfaces;
using MediatR;
using MedCard.Application.Interfaces;

namespace MedCard.Aplication.MedCard.Commands.CreateMedCard;
/// <summary>
/// Обработчик создания карты
/// </summary>
public class CreateMedCardCommandHandler : IRequestHandler<CreateMedCardCommand, Guid>
{
    private readonly IMedCardDbContext _dbContext;

    public CreateMedCardCommandHandler(IMedCardDbContext dbContext) => _dbContext = dbContext;
    
    public async Task<Guid> Handle(CreateMedCardCommand request,
        CancellationToken cancellationToken)
    {
        var medCard = new Domain.MedCard
        {
            UserId = request.UserId,
            Title = request.Title,
            Details = request.Details,
            Id = Guid.NewGuid(),
            CreateDate = DateTime.Now,
            EditDate = null
        };
        /// добавление карты в контекст
        await _dbContext.MedCard.AddAsync(medCard, cancellationToken);
        /// сохранение изменений карты в бд
        await _dbContext.SaveChangesAsync(cancellationToken);
        
        return medCard.Id;
    }
}