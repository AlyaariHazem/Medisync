using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MedisyncAPI.models;

namespace MedisyncAPI.Repositories.Interfaces;


public interface IMedicationRepository
{
    Task<IEnumerable<Medication>> GetAllMedicationsAsync();
    Task<Medication?> GetMedicationByIdAsync(int id);
    Task AddMedicationAsync(Medication medication);
    Task SaveChangesAsync();
    Task<IEnumerable<Medication>> SearchMedicationsAsync(string query);
    Task DeleteMedication(Medication medication);
}

