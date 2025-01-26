using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MedisyncAPI.models;

public class Interaction
{
    public int Id { get; set; }

    // Foreign keys
    public int Medication1Id { get; set; }
    public int Medication2Id { get; set; }

    public string? InteractionType { get; set; } = string.Empty;
    public string? Reasoning { get; set; } = string.Empty;

    // Add these new properties
    public string? Pros { get; set; } = string.Empty;
    public string? Cons { get; set; } = string.Empty;
    public string Severity { get; set; } = string.Empty;

    [JsonIgnore]
    public Medication? Medication1 { get; set; }
    [JsonIgnore]
    public Medication? Medication2 { get; set; }
}
