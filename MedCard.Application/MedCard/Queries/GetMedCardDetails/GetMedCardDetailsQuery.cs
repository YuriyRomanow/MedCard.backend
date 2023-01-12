using MediatR;

namespace MedCard.Aplication.MedCard.Queries.GetMedCardDetails;
/// <summary>
/// получение данных карты
/// </summary>
public class GetMedCardDetailsQuery : IRequest<MedCardDetailsVm>
{
    public Guid UserId { get; set; }
    public Guid Id { get; set; }
}