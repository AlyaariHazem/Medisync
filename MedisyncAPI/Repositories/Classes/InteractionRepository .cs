using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MedisyncAPI.Data;
using MedisyncAPI.models;
using MedisyncAPI.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MedisyncAPI.Repositories.Classes
{
    public class InteractionRepository : IInteractionRepository
    {
        private readonly AppDbContext _context;

        public InteractionRepository(AppDbContext context)
        {
            _context = context;
        }

        // 1. Get all interactions
        public async Task<IEnumerable<Interaction>> GetAllInteractionsAsync()
        {
            return await _context.Interactions
                .Include(i => i.Medication1)
                .Include(i => i.Medication2)
                .ToListAsync();
        }

        // 2. Add multiple interactions
        public async Task AddInteractionsAsync(List<Interaction> interactions)
        {
            await _context.Interactions.AddRangeAsync(interactions);
        }

        // 3. Commit changes
        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

        // 5. NEW: Get interactions by medication NAMES
        public async Task<IEnumerable<Interaction>> GetInteractionsForMedicationNamesAsync(List<string> medicationNames)
        {
            // Safety check.
            if (medicationNames == null || medicationNames.Count < 2)
            {
                throw new ArgumentException("At least two medication names must be provided.");
            }

            // 1. Find the Medication IDs that match the given names
            var medicationIds = await _context.Medications
                .Where(m => medicationNames.Contains(m.Name))
                .Select(m => m.Id)
                .ToListAsync();

            // 2. Make sure we found at least two
            if (medicationIds.Count < 2)
            {
                return new List<Interaction>();
            }

            // 3. Fetch interactions only where *both* Medication1 and Medication2
            //    belong to the selected medication IDs
            return await _context.Interactions
                .Where(i => medicationIds.Contains(i.Medication1Id) 
                        && medicationIds.Contains(i.Medication2Id))
                .Include(i => i.Medication1)
                .Include(i => i.Medication2)
                .ToListAsync();
        }


        // 6. Get a single interaction by ID (return null if not found)
        public async Task<Interaction?> GetInteractionByIdAsync(int id)
        {
            return await _context.Interactions
                .Include(i => i.Medication1)
                .Include(i => i.Medication2)
                .FirstOrDefaultAsync(i => i.Id == id);
        }

        // 7. Delete interaction
        public async Task DeleteInteraction(Interaction interaction)
        {
            _context.Interactions.Remove(interaction);
            await _context.SaveChangesAsync();
        }
    }
}
