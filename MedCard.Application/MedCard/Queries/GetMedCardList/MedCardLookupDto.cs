using AutoMapper;
using MedCard.Application.Common.Mapping;

namespace MedCard.Application.MedCard.Queries.GetMedCardList;
/// <summary>
/// класс содержайщий список карт
/// создается класс MedCardLookupDto и мапится с классом MedCard
/// </summary>
public class MedCardLookupDto : IMapWith<Domain.MedCard.MedCard>
{
    public Guid Id { get; set; }
    public string Title { get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<Domain.MedCard.MedCard, MedCardLookupDto>()
            .ForMember(cardDto => cardDto.Id,
                opt => opt.MapFrom(card => card.Id))
            .ForMember(cardDto => cardDto.Title,
                opt => opt.MapFrom(card => card.Title));
    }
}