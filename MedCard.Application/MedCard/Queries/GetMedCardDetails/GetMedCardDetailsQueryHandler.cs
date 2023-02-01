using AutoMapper;
using MedCard.Application.Common.Exceptions;
using MedCard.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MedCard.Application.MedCard.Queries.GetMedCardDetails;

public class GetMedCardDetailsQueryHandler : IRequestHandler<GetMedCardDetailsQuery, MedCardDetailsVm>
{
    private readonly IMedCardDbContext _dbContext;
    private readonly IMapper _mapper;

    public GetMedCardDetailsQueryHandler(IMedCardDbContext dbContext, IMapper mapper) =>
        (_dbContext, _mapper) = (dbContext, mapper);

    public async Task<MedCardDetailsVm> Handle(GetMedCardDetailsQuery request, CancellationToken cancellationToken)
    {
        var entity = await _dbContext.MedCard
            .FirstOrDefaultAsync(card => card.Id == request.Id, cancellationToken);

        if (entity == null || entity.UserId != request.UserId)
        {
            throw new NotFoundExceptions(nameof(MedCard), request.Id);
        }

        return _mapper.Map<MedCardDetailsVm>(entity);
    }
}