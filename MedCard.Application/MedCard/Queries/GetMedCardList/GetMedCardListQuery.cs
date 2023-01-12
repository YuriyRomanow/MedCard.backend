using MediatR;

namespace MedCard.Aplication.MedCard.Queries.GetMedCardList;

public class GetMedCardListQuery : IRequest<MedCardListVm>
{
    public Guid UserId { get; set; }
}