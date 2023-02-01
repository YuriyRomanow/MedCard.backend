using AutoMapper;
using MedCard.Application.Common.Mapping;

namespace MedCard.Application.MedCard.Queries.GetMedCardDetails;
/// <summary>
/// мапинг деталей карты
/// </summary>
public class MedCardDetailsVm : IMapWith<Domain.MedCard.MedCard>
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Details { get; set; }
    public DateTime CreateDate { get; set; }
    public DateTime? EditDate { get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<Domain.MedCard.MedCard, MedCardDetailsVm>()
            .ForMember(cardVm => cardVm.Title,
                opt => opt.MapFrom(card => card.Title))
            .ForMember(cardVm => cardVm.Details,
                opt => opt.MapFrom(card => card.Details))
            .ForMember(cardVm => cardVm.Id,
                opt => opt.MapFrom(card => card.Id))
            .ForMember(cardVm => cardVm.CreateDate,
                opt => opt.MapFrom(card => card.CreateDate))
            .ForMember(cardVm => cardVm.EditDate,
                opt => opt.MapFrom(card => card.EditDate));
    }
}