using Project.API.Model.Domain;

namespace Project.API.Repository.Interface
{
    public interface IUserRepository
    {
        Task<User> GetUser(Guid id);
        Task<User> AddUser(User user);
    }
}