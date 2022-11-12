using BackEnd.Models;
using BackEnd.Dtos.Users;

namespace BackEnd.Repositories
{
    public interface IUserRepository
    {
        Task<GetUserDto> GetUser(int id);
        Task<IEnumerable<User>> GetAllUsers();
        Task<GetUserDto> DeleteUser(int id);
        Task<GetUserDto> UpdateUser(UpdateUserDto newUser);
        Task<GetUserDto> CreateUser(CreateUserDto newUser);

    }
}