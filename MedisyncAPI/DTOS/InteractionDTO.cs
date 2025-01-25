using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MedisyncAPI.models;

namespace MedisyncAPI.DTOS;

public class InteractionDTO
{
    public int Medication1Id { get; set; }
    public int Medication2Id { get; set; }
    
    public string InteractionType { get; set; } = string.Empty;
    public string Reasoning { get; set; } = string.Empty;

    // Add the new fields
    public string? Pros { get; set; } 
    public string? Cons { get; set; }
    public SeverityLevel Severity { get; set; } = SeverityLevel.None;
}

