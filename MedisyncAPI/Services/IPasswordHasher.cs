using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedisyncAPI.Services;

 public interface IPasswordHasher
{
    string HashPassword(string password);
    bool VerifyPassword(string hashedPassword, string providedPassword);
}
