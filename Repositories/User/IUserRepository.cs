using ECommerceAppBackend.Models;

namespace ECommerceAppBackend.Repositories.User;

public interface IUserRepository
{
    IEnumerable<UserModel> GetAllUsers();
    UserModel GetUserById(int id);
    void CreateNewUser(UserModel user);
    UserModel GetUserByEmail(string email);
}