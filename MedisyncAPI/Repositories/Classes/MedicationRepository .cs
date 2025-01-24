using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MedisyncAPI.Data;
using MedisyncAPI.models;
using MedisyncAPI.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MedisyncAPI.Repositories.Classes;


public class MedicationRepository : IMedicationRepository
{
    private readonly AppDbContext _context;

    public MedicationRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Medication>> GetAllMedicationsAsync()
    {
        return await _context.Medications.ToListAsync();
    }

    public async Task<Medication?> GetMedicationByIdAsync(int id)
    {
        return await _context.Medications.FindAsync(id);
    }

    public async Task AddMedicationAsync(Medication medication)
    {
        await _context.Medications.AddAsync(medication);
    }

    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }
    
    public async Task<IEnumerable<Medication>> SearchMedicationsAsync(string query)
    {
        var medications = await _context.Medications
                            .Where(m => m.Name.Contains(query))
                            .ToListAsync();

        if (medications == null)
        {
            return null;
        }
        return medications;
    }

    public async Task DeleteMedication(Medication medication)
    {
        _context.Medications.Remove(medication);
        await _context.SaveChangesAsync();
    }

}

