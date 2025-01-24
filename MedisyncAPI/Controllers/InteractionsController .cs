
using Microsoft.AspNetCore.Mvc;
using MedisyncAPI.models;
using MedisyncAPI.Data;
using System.Collections.Generic;
using System.Threading.Tasks;
using MedisyncAPI.Repositories.Interfaces;
using MedisyncAPI.DTOS;

namespace MedisyncAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class InteractionsController : ControllerBase
{
    private readonly IInteractionRepository _interactionRepository;

    public InteractionsController(IInteractionRepository interactionRepository)
    {
        _interactionRepository = interactionRepository;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Interaction>>> GetInteractions()
    {
        var interactions = await _interactionRepository.GetAllInteractionsAsync();
        return Ok(interactions);
    }

   [HttpPost]
    public async Task<IActionResult> AddInteractions(List<InteractionDTO> interactionDtos)
    {
        if (interactionDtos == null || interactionDtos.Count == 0)
        {
            return BadRequest("No interactions provided.");
        }

        var interactions = interactionDtos.Select(dto => new Interaction
        {
            Medication1Id = dto.Medication1Id,
            Medication2Id = dto.Medication2Id,
            InteractionType = dto.InteractionType,
            Reasoning = dto.Reasoning
        }).ToList();

        await _interactionRepository.AddInteractionsAsync(interactions);
        await _interactionRepository.SaveChangesAsync();

        return Ok(interactions);
    }

    [HttpPost("check")]
    public async Task<IActionResult> CheckDrugInteractions([FromBody] List<int> medicationIds)
    {
        if (medicationIds == null || medicationIds.Count < 2)
        {
            return BadRequest("You must select at least two medications to check interactions.");
        }

        var interactions = await _interactionRepository.GetInteractionsForMedicationsAsync(medicationIds);
        return Ok(interactions);
    }


    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateInteraction(int id, InteractionDTO interactionDto)
    {
        var interaction = await _interactionRepository.GetInteractionByIdAsync(id);
        if (interaction == null) return NotFound();

        interaction.Medication1Id = interactionDto.Medication1Id;
        interaction.Medication2Id = interactionDto.Medication2Id;
        interaction.InteractionType = interactionDto.InteractionType;
        interaction.Reasoning = interactionDto.Reasoning;

        await _interactionRepository.SaveChangesAsync();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteInteraction(int id)
    {
        var interaction = await _interactionRepository.GetInteractionByIdAsync(id);
        if (interaction == null) return NotFound();

        await _interactionRepository.DeleteInteraction(interaction);
        return NoContent();
    }

}
