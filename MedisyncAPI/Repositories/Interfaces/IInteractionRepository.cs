using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MedisyncAPI.models;

namespace MedisyncAPI.Repositories.Interfaces;


public interface IInteractionRepository
{
    Task<IEnumerable<Interaction>> GetAllInteractionsAsync();
    Task AddInteractionsAsync(List<Interaction> interaction);
    Task SaveChangesAsync();
    Task<IEnumerable<Interaction>> GetInteractionsForMedicationNamesAsync(List<string> medicationNames);
    Task<Interaction> GetInteractionByIdAsync(int id);
    Task DeleteInteraction(Interaction interaction);
}

