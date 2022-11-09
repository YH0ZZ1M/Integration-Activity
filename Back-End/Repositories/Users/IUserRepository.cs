using BackEnd.Models;

namespace BackEnd.Repositories
{
    public interface IUserRepository
    {
        User GetUser(int id);
        void DeleteUser(int id);
    }
}