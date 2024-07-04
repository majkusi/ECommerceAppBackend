using ECommerceAppBackend.Data;
using ECommerceAppBackend.Models;

namespace ECommerceAppBackend.Repositories.User;

public class UserRepository : IUserRepository
{
    private readonly AppDbContext _context;

    public UserRepository(AppDbContext context)
    {
        _context = context;
    }
    public UserModel GetUserByEmail(string email)
    {
        return _context.Users.FirstOrDefault(x => x.Email == email)!;
    }

    public IEnumerable<UserModel> GetAllUsers()
    {
        return _context.Users;
    }

    public UserModel GetUserById(int id)
    {
        return _context.Users.Find(id)!;
    }
    
    public void CreateNewUser(UserModel user)
    {
        var newUser = _context.Users.Add(user);
        Save();   
    }
    
    private void Save()
    {
        _context.SaveChanges();
    }
}