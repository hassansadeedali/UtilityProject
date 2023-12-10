using Project.API.Data;
using Project.API.Model.Domain;
using Project.API.Repository.Interface;

namespace Project.API.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext dbContext;

        public UserRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<User> GetUser(Guid id)
        {
            var user = dbContext.Users.Where(x => x.id.Equals(id)).FirstOrDefault();
            return user;
        }

        public async Task<User> AddUser(User user)
        {
            await dbContext.Users.AddAsync(user);
            await dbContext.SaveChangesAsync();
            return user;
        }
    }
}
