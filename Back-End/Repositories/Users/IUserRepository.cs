using BackEnd.Models;
using BackEnd.Dtos.Users;

namespace BackEnd.Repositories
{
    public interface IUserRepository
    {
        Task<RepositoryResponse<GetUserDto>> GetUser(int id);
        Task<RepositoryResponse<List<GetUserDto>>> GetAllUsers();
        Task<RepositoryResponse<GetUserDto>> DeleteUser(int id);
        Task<RepositoryResponse<GetUserDto>> UpdateUser(UpdateUserDto newUser);
        Task<RepositoryResponse<User>> CreateUser(CreateUserDto newUser);

    }
}