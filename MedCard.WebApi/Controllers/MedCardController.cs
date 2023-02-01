using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MedCard.Application.MedCard.Commands.CreateMedCard;
using MedCard.Application.MedCard.Commands.UpdateMedCard;
using MedCard.Application.MedCard.Commands.DeleteMedCard;
using MedCard.Application.MedCard.Queries.GetMedCardDetails;
using MedCard.Application.MedCard.Queries.GetMedCardList;
using MedCard.WebApi.Models;


namespace MedCard.WebApi.Controllers;
[Route("api/[controller]")]
public class MedCardController : BaseController
{
    private readonly IMapper _mapper;
    public MedCardController(IMapper mapper) => _mapper = mapper;
    
    
    [HttpGet]
    public async Task<ActionResult<MedCardListVm>> GetAll()
    {
        var query = new GetMedCardListQuery
        {
            UserId = UserId
        };
        var vm = await Mediator.Send(query);
        return Ok(vm);
    }
    
    
    [HttpGet("{id}")]
    public async Task<ActionResult<MedCardDetailsVm>> Get(Guid id)
    {
        var query = new GetMedCardDetailsQuery
        {
            UserId = UserId,
            Id = id
        };
        var vm = await Mediator.Send(query);
        return Ok(vm);
    }

    [HttpPost]
    public async Task<ActionResult<Guid>> Create([FromBody] CreateMedCardDto createMedCardDto)
    {
        var command = _mapper.Map<CreateMedCardCommand>(createMedCardDto);
        command.UserId = UserId;
        var noteId = await Mediator.Send(command);
        return Ok(noteId);
    }

    [HttpPut]
    public async Task<ActionResult> Update([FromBody] UpdateMedCardDto updateMedCardDto)
    {
        var command = _mapper.Map<UpdateMedCardCommand>(updateMedCardDto);
        command.UserId = UserId;
        await Mediator.Send(command);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var command = new DeleteMedCardCommand
        {
            Id = id,
            UserId = UserId
        };
        await Mediator.Send(command);
        return NoContent();
    }
}