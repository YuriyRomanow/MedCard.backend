using MedCard.Aplication.Common.Exceptions;
using MedCard.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MedCard.Aplication.MedCard.Commands.UpdateMedCard;
/// <summary>
/// Обработчик изменения карты
/// </summary>
public class UpdateMedCardCommandHandler : IRequestHandler<UpdateMedCardCommand>
{
    private readonly IMedCardDbContext _dbContext;

    public UpdateMedCardCommandHandler(IMedCardDbContext dbContext) => _dbContext = dbContext;
    
    public async Task<Unit> Handle(UpdateMedCardCommand request, CancellationToken cancellationToken)
    {
        var entity = await _dbContext.MedCard.FirstOrDefaultAsync(card => card.Id == request.Id, cancellationToken);

        if (entity == null || entity.UserId != request.UserId)
        {
            throw new NotFoundExceptions(nameof(MedCard), request.Id);
        }

        entity.Title = request.Title;
        entity.Details = request.Details;
        entity.EditDate = DateTime.Now;

        await _dbContext.SaveChangesAsync(cancellationToken);
        
        return Unit.Value;
    }
}