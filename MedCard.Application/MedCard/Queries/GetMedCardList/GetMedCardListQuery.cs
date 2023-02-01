using MediatR;

namespace MedCard.Application.MedCard.Queries.GetMedCardList;

public class GetMedCardListQuery : IRequest<MedCardListVm>
{
    public Guid UserId { get; set; }
}