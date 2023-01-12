using MediatR;

namespace MedCard.Aplication.MedCard.Commands.DeleteMedCard;
/// <summary>
/// удаление карты
/// </summary>
public class DeleteMedCardCommand : IRequest
{
    public Guid UserId { get; set; }
    public Guid Id { get; set; }
}