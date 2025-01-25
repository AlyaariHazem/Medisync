using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MedisyncAPI.models;

public class RegisterModel
{
    [Required]
    [MinLength(4)]
    public string Username { get; set; }=string.Empty;

    [Required]
    [MinLength(6)]
    public string Password { get; set; }=string.Empty;

}
