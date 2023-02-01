using MediatR;

namespace MedCard.Application.MedCard.Commands.UpdateMedCard;

/// <summary>
///  Команда изменения карты
///  Guid - id карты
///  Title - заголовок
///  Details - детали
/// </summary>

public class UpdateMedCardCommand : IRequest
{
    public Guid UserId { get; set; }
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Details { get; set; }
}