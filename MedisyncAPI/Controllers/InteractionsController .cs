using Microsoft.AspNetCore.Mvc;
using MedisyncAPI.models;
using MedisyncAPI.DTOS;
using MedisyncAPI.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedisyncAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InteractionsController : ControllerBase
    {
        private readonly IInteractionRepository _interactionRepository;

        public InteractionsController(IInteractionRepository interactionRepository)
        {
            _interactionRepository = interactionRepository;
        }

        // GET: api/Interactions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Interaction>>> GetInteractions()
        {
            var interactions = await _interactionRepository.GetAllInteractionsAsync();
            return Ok(interactions);
        }

        // POST: api/Interactions (add multiple interactions)
       [HttpPost]
        public async Task<IActionResult> AddInteractions([FromBody] List<InteractionDTO> interactionDtos)
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
                Reasoning = dto.Reasoning,

                Pros = dto.Pros,
                Cons = dto.Cons,
                Severity = dto.Severity
            }).ToList();

            await _interactionRepository.AddInteractionsAsync(interactions);
            await _interactionRepository.SaveChangesAsync();

            return Ok(interactions);
        }


        // NEW: POST: api/Interactions/checkByName (check by medication NAMES)
        [HttpPost("checkByName")]
        public async Task<IActionResult> CheckDrugInteractionsByName([FromBody] List<string> medicationNames)
        {
            if (medicationNames == null || medicationNames.Count < 2)
            {
                return BadRequest("You must provide at least two medication names to check interactions.");
            }

            var interactions = await _interactionRepository.GetInteractionsForMedicationNamesAsync(medicationNames);
            return Ok(interactions);
        }

        // PUT: api/Interactions/5
       [HttpPut("{id}")]
        public async Task<IActionResult> UpdateInteraction(int id, [FromBody] InteractionDTO interactionDto)
        {
            var interaction = await _interactionRepository.GetInteractionByIdAsync(id);
            if (interaction == null)
                return NotFound("Interaction not found");

            interaction.Medication1Id = interactionDto.Medication1Id;
            interaction.Medication2Id = interactionDto.Medication2Id;
            interaction.InteractionType = interactionDto.InteractionType;
            interaction.Reasoning = interactionDto.Reasoning;

            interaction.Pros = interactionDto.Pros;
            interaction.Cons = interactionDto.Cons;
            interaction.Severity = interactionDto.Severity;

            await _interactionRepository.SaveChangesAsync();
            return NoContent();
        }


        // DELETE: api/Interactions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInteraction(int id)
        {
            var interaction = await _interactionRepository.GetInteractionByIdAsync(id);
            if (interaction == null)
                return NotFound("Interaction not found");

            await _interactionRepository.DeleteInteraction(interaction);
            return NoContent();
        }
    }
}
