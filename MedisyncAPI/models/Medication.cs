using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MedisyncAPI.models;

public class Medication
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Use { get; set; } = string.Empty;
    public string? SideEffects { get; set; } = string.Empty;
    [JsonIgnore]
    public ICollection<Interaction>? InteractionsAsMed1 { get; set; }
    [JsonIgnore]
    public ICollection<Interaction>? InteractionsAsMed2 { get; set; }
}