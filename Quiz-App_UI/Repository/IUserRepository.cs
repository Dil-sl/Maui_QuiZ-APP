using Quiz_App_UI.Model;

namespace Quiz_App_UI.Repository
{
    public interface IUserRepository
    {
        Task<User> Login(string email, string password);
    }
}
