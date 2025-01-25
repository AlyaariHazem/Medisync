using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MedisyncAPI.models;

public class User
{
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Username { get; set; }=string.Empty;

        [Required]
        public string PasswordHash { get; set; }=string.Empty;
}
