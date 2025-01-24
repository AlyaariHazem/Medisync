using Microsoft.AspNetCore.Mvc;
using MedisyncAPI.models;
using MedisyncAPI.Data;
using System.Collections.Generic;
using System.Threading.Tasks;
using MedisyncAPI.Repositories.Interfaces;
using MedisyncAPI.DTOS;

[ApiController]
[Route("api/[controller]")]
public class MedicationsController : ControllerBase
{
    private readonly IMedicationRepository _medicationRepository;

    public MedicationsController(IMedicationRepository medicationRepository)
    {
        _medicationRepository = medicationRepository;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Medication>>> GetMedications()
    {
        var medications = await _medicationRepository.GetAllMedicationsAsync();
        return Ok(medications);
    }

   [HttpGet("{id}")]
    public async Task<IActionResult> GetMedication(int id)
    {
        try
        {
            var medication = await _medicationRepository.GetMedicationByIdAsync(id);
            if (medication == null) return NotFound("Medication not found.");

            return Ok(medication);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }


    [HttpPost]
    public async Task<IActionResult> AddMedications(List<MedicationDTO> medicationDtos)
    {
        foreach (var medicationDto in medicationDtos)
        {
            var medication = new Medication
            {
                Name = medicationDto.Name,
                Use = medicationDto.Use,
                SideEffects = medicationDto.SideEffects
            };

            await _medicationRepository.AddMedicationAsync(medication);
        }
        await _medicationRepository.SaveChangesAsync();

        return Ok("Medications added successfully.");
    }


    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateMedication(int id, MedicationDTO medicationDto)
    {
        var medication = await _medicationRepository.GetMedicationByIdAsync(id);
        if (medication == null) return NotFound();

        medication.Name = medicationDto.Name;
        medication.Use = medicationDto.Use;
        medication.SideEffects = medicationDto.SideEffects;

        await _medicationRepository.SaveChangesAsync();
        return Ok("Medications updated successfully.");
    }

    [HttpGet("search")]
    public async Task<ActionResult<IEnumerable<Medication>>> SearchMedications(string query)
    {
        var medications = await _medicationRepository.SearchMedicationsAsync(query);

        if(medications==null)
        {
            return NotFound("No medications found.");
        }
        return Ok(medications);
    }
    
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteMedication(int id)
    {
        var medication = await _medicationRepository.GetMedicationByIdAsync(id);
        if (medication == null) return NotFound();

       await _medicationRepository.DeleteMedication(medication);
        return Ok("Medication deleted successfully.");
    }

}
