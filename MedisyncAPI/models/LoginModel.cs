using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MedisyncAPI.models;

public class LoginModel
{
    [Required]
    public string Username { get; set; }=string.Empty;

    [Required]
    public string Password { get; set; }=string.Empty;
}
