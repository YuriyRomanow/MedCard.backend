using AutoMapper;
using AutoMapper.QueryableExtensions;
using MedCard.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MedCard.Application.MedCard.Queries.GetMedCardList;

public class GetMedCardListQueryHandler : IRequestHandler<GetMedCardListQuery, MedCardListVm>
{
    private readonly IMedCardDbContext _dbContext;
    private readonly IMapper _mapper;

    public GetMedCardListQueryHandler(IMedCardDbContext dbContext, IMapper mapper) =>
        (_dbContext, _mapper) = (dbContext, mapper);

    public async Task<MedCardListVm> Handle(GetMedCardListQuery request, CancellationToken cancellationToken)
    {
        var cardQuery = await _dbContext.MedCard
            .Where(card => card.UserId == request.UserId)
            .ProjectTo<MedCardLookupDto>(_mapper.ConfigurationProvider)
            .ToListAsync(cancellationToken);

        return new MedCardListVm { MedCard = cardQuery };
    }
}