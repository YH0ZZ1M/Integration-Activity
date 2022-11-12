using BackEnd.Models;
using BackEnd.Dtos.Users;

namespace BackEnd.Repositories
{
    public interface IUserRepository
    {
        Task<GetUserDto> GetUser(int id);
        Task<IEnumerable<User>> GetAllUsers();
        User DeleteUser(int id);
        User UpdateUser(UpdateUserDto newUser);
        User CreateUser(CreateUserDto newUser);

    }
}