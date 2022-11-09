using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackEnd.Models;
using BackEnd.Repositories;

namespace BackEnd.Repositories
{
    public class UserRepository : IUserRepository
    {
        
        public void DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public User GetUser(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<RepositoryResponse<GetUserDto>>>GetAllUsers()
        {
            var response = new RepositoryResponse<List<GetCharacterDto>>();
            var dbCharacters = await _context.Characters.
            Where(c=> c.User.Id == GetUserId()).ToListAsync(); 
            response.Data = dbCharacters.Select(c=> _mapper.Map<GetCharacterDto>(c)).ToList();
            return response;
        }

    }
}