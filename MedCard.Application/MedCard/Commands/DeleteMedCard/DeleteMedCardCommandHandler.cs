using MedCard.Application.Common.Exceptions;
using MedCard.Application.Interfaces;
using MediatR;

namespace MedCard.Application.MedCard.Commands.DeleteMedCard;
/// <summary>
/// Обработчик удаление карты
/// </summary>
public class DeleteMedCardCommandHandler : IRequestHandler<DeleteMedCardCommand>
{
    private readonly IMedCardDbContext _dbContext;

    public DeleteMedCardCommandHandler(IMedCardDbContext dbContext) => _dbContext = dbContext;

    public async Task<Unit> Handle(DeleteMedCardCommand request, CancellationToken cancellationToken)
    {
        var entity = await _dbContext.MedCard.FindAsync(new object[] { request.Id }, cancellationToken);

        if (entity == null || entity.UserId != request.UserId)
        {
            throw new NotFoundExceptions(nameof(MedCard), request.Id);
        }

        _dbContext.MedCard.Remove(entity);
        await _dbContext.SaveChangesAsync(cancellationToken);
        
        return Unit.Value;
    }
}