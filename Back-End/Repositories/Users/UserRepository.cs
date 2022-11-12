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
        public UserCollec _coll {get;}

        public UserRepository(UserCollec collection)
        {
            this._coll = collection;
        }

        public DataContext _context {get;}

        public UserRepository(DataContext context)
        {
            this._context = context;
        }

        //GET ALL USERS
        
        public async Task<IEnumerable<User>>GetAllUsers()
        {
            return await _context.Users.ToListAsync();            
        }

        //GET USER
        public async Task<GetUserDto> GetUser(int id)
        {
            var response = await _context.Users.FirstOrDefaultAsync(u => u.Id == id);
            if (response is null)
            {
                throw new NullReferenceException($"User with ID {id} not found");
            }
            return response.AsDto();
        }

        //CREATE NEW USER
        public User CreateUser(CreateUserDto newUser)
        {
            User ne = new User(){
                Id = _coll.collection.Count +1,
                Name = newUser.Name,
                UserType = (TypeUser) newUser.UserType,
                Email = newUser.Email,
                Phone = newUser.Phone,
            };
            _coll.collection.Add(ne);
            return ne;
        }

        //DELETE USER
        public User DeleteUser(int id)
        {
            User ol = _coll.collection.Find(u => u.Id ==id);
             if (ol is null)
            {
                throw new NullReferenceException($"User not found");
            }
            _coll.collection.Remove(ol);
            return ol;
        }

        //UPDATE USER
        public User UpdateUser(UpdateUserDto newUser)
        {
            User up = _coll.collection.Find(u => u.Id == newUser.Id);
            if (up != null)
            {
                int ind = _coll.collection.IndexOf(up);
                User ne = new User(){
                    Id = _coll.collection.Count +1,
                    Name = newUser.Name,
                    UserType = (TypeUser) newUser.UserType,
                    Email = newUser.Email,
                    Phone = newUser.Phone,
                };
                _coll.collection[ind] = ne;
                return _coll.collection[ind];
            } 
                else{
                    return new User();
                }
        }
    }
}

















          
