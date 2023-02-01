using AutoMapper;
using MedCard.Application.MedCard.Commands.CreateMedCard;
using MedCard.Application.Common.Mapping;

namespace MedCard.WebApi.Models;

public class CreateMedCardDto : IMapWith<CreateMedCardDto>
{
    public string Title { get; set; }
    public string Details { get; set; }
    
    public void Mapping(Profile profile)
    {
        profile.CreateMap<CreateMedCardDto, CreateMedCardCommand>()
            .ForMember(medCardCommand => medCardCommand.Title,
                opt => opt.MapFrom(medCardDto => medCardDto.Title))
            .ForMember(medCardCommand => medCardCommand.Details,
                opt => opt.MapFrom(medCardDto => medCardDto.Details));
    }


}