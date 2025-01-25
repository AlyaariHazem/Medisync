using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MedisyncAPI.models;

namespace MedisyncAPI.Repositories.Interfaces;

 public interface IUserRepository
{
    Task<User> GetUserByUsernameAsync(string username);
    Task CreateUserAsync(User user);
}
