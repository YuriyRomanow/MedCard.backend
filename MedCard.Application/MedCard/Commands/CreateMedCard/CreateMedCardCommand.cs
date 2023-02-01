using MediatR;

namespace MedCard.Application.MedCard.Commands.CreateMedCard;

/// <summary>
///  Команда создания карты
///  Guid - id карты
///  Title - заголовок
///  Details - детали
/// </summary>
public abstract class CreateMedCardCommand : IRequest<Guid>
{
    public Guid UserId { get; set; }
    public string Title { get; set; }
    public string Details { get; set; }
}