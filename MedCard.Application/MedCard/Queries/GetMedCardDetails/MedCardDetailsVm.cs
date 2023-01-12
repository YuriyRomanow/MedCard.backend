using AutoMapper;
using MedCard.Application.Common.Mapping;
using MedCard.Domain;
namespace MedCard.Aplication.MedCard.Queries.GetMedCardDetails;
/// <summary>
/// мапинг деталей карты
/// </summary>
public class MedCardDetailsVm : IMapWith<Domain.MedCard>
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Details { get; set; }
    public DateTime CreateDate { get; set; }
    public DateTime? EditDate { get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<Domain.MedCard, MedCardDetailsVm>()
            .ForMember(cardVM => cardVM.Title,
                opt => opt.MapFrom(card => card.Title))
            .ForMember(cardVM => cardVM.Details,
                opt => opt.MapFrom(card => card.Details))
            .ForMember(cardVM => cardVM.Id,
                opt => opt.MapFrom(card => card.Id))
            .ForMember(cardVM => cardVM.CreateDate,
                opt => opt.MapFrom(card => card.CreateDate))
            .ForMember(cardVM => cardVM.EditDate,
                opt => opt.MapFrom(card => card.EditDate));
    }
}