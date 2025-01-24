using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MedisyncAPI.Data;
using MedisyncAPI.models;
using MedisyncAPI.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MedisyncAPI.Repositories.Classes;


public class InteractionRepository : IInteractionRepository
{
    private readonly AppDbContext _context;

    public InteractionRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Interaction>> GetAllInteractionsAsync()
    {
        return await _context.Interactions.Include(i => i.Medication1).Include(i => i.Medication2).ToListAsync();
    }

    public async Task AddInteractionsAsync(List<Interaction> interactions)
    {
        await _context.Interactions.AddRangeAsync(interactions);
    }

    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }
   
    public async Task<IEnumerable<Interaction>> GetInteractionsForMedicationsAsync(List<int> medicationIds)
    {
        return await _context.Interactions
                            .Where(i => medicationIds.Contains(i.Medication1Id) || medicationIds.Contains(i.Medication2Id))
                            .Include(i => i.Medication1)
                            .Include(i => i.Medication2)
                            .ToListAsync();
    }


    public async Task<Interaction> GetInteractionByIdAsync(int id)
    {
        var interaction = await _context.Interactions.FindAsync(id);
        if (interaction == null)
        {
            throw new Exception("Interaction not found");
        }
        return interaction;
    }

    public async Task DeleteInteraction(Interaction interaction)
    {
        _context.Interactions.Remove(interaction);
        await _context.SaveChangesAsync();
    }

}

