using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedisyncAPI.DTOS;

public class InteractionDTO
{
    public int Medication1Id { get; set; }
    public int Medication2Id { get; set; }
    public string InteractionType { get; set; } = string.Empty;
    public string Reasoning { get; set; }= string.Empty;
}