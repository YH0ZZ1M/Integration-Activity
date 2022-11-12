using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BackEnd.Models;
using BackEnd.Dtos.Users;
using BackEnd.Data;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd.Repositories
{
    public class UserRepository : IUserRepository
    {
        public DataContext _context;

        public UserRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<User>>GetAllUsers()
        {
            return await _context.Users.ToListAsync();            
        }

        public async Task<GetUserDto> GetUser(int id)
        {
            var response = await _context.Users.FirstOrDefaultAsync(c => c.Id == id);
            if (response is null)
            {
                throw new NullReferenceException($"User with ID {id} not found");
            }
            return response.AsDto();
        }

        public Task<GetUserDto> CreateUser(CreateUserDto newUser)
        {
            throw new NotImplementedException();
        }

        public Task<GetUserDto> DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public Task<GetUserDto> UpdateUser(UpdateUserDto newUser)
        {
            throw new NotImplementedException();
        }
    }
}

















          
