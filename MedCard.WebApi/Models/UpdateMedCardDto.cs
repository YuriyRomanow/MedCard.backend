using AutoMapper;
using MedCard.Application.MedCard.Commands.UpdateMedCard;
using MedCard.Application.Common.Mapping;

namespace MedCard.WebApi.Models;

public class UpdateMedCardDto : IMapWith<UpdateMedCardCommand>
{
    
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Details { get; set; }
    
    public void Mapping(Profile profile)
    {
        profile.CreateMap<UpdateMedCardDto, UpdateMedCardCommand>()
            .ForMember(medCardCommand => medCardCommand.Id,
                opt => opt.MapFrom(medCardDto => medCardDto.Id))
            .ForMember(medCardCommand => medCardCommand.Title,
                opt => opt.MapFrom(medCardDto => medCardDto.Title))
            .ForMember(medCardCommand => medCardCommand.Details,
                opt => opt.MapFrom(medCardDto => medCardDto.Details));
    }
}