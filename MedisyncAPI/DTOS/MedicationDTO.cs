using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedisyncAPI.DTOS;

public class MedicationDTO
{
    public string Name { get; set; } =string.Empty;
    public string Use { get; set; }=string.Empty;
    public string? SideEffects { get; set; }=string.Empty;
}

