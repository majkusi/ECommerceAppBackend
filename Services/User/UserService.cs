using ECommerceAppBackend.Repositories.User;

namespace ECommerceAppBackend.Services.User
{
    public class UserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void ActivateUserAccount(string email){
            try
            {
                if (_userRepository.GetUserByEmail(email) != null)
                {
                    _userRepository.ConfirmEmail(email);
                }
            }catch(Exception e){
                Console.WriteLine(e.Message);
            }
        }
    }
}
