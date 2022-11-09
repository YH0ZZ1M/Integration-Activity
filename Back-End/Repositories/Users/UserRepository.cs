using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BackEnd.Models;
using BackEnd.Dtos.Users;
using BackEnd.Data;

namespace BackEnd.Repositories
{
    public class UserRepository : IUserRepository
    {
        public DataContext _context;

        public UserRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<RepositoryResponse<List<GetUserDto>>> GetAllUsers()
        {
            // var response =  new RepositoryResponse<List<GetUserDto>>();
            // response.Data = await _context.Users.ToListAsync();
            // return response;
            //return await _context.Users.ToListAsync();
             throw new NotImplementedException();
        }

        public Task<RepositoryResponse<GetUserDto>> GetUser(int id)
        {
            throw new NotImplementedException();
        }
        public Task<RepositoryResponse<User>> CreateUser(CreateUserDto newUser)
        {
            throw new NotImplementedException();
        }

        public Task<RepositoryResponse<GetUserDto>> DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public Task<RepositoryResponse<GetUserDto>> UpdateUser(UpdateUserDto newUser)
        {
            throw new NotImplementedException();
        }
    }
}

















          
