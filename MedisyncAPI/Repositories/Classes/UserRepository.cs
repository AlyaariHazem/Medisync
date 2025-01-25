using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MedisyncAPI.Data;
using MedisyncAPI.models;
using MedisyncAPI.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MedisyncAPI.Repositories.Classes;

public class UserRepository : IUserRepository
{
    private readonly AppDbContext _context;
    
    public UserRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<User> GetUserByUsernameAsync(string username)
    {
        return await _context.Users
                            .FirstOrDefaultAsync(u => u.Username.ToLower() == username.ToLower());
    }

    public async Task CreateUserAsync(User user)
    {
        _context.Users.Add(user);
        await _context.SaveChangesAsync();
    }
}
