

using Domain.Entities;
using Persistence.Contexts;
using Application.Interface.Persistence;

namespace Persistence.Repositories
{
    // This is standard template code only for understanding to developer later it will be removed
    public class UserRepository : IUserRepository
    {
        private readonly DapperContext _applicationContext;

        public UserRepository(DapperContext applicationContext)
        {
            _applicationContext = applicationContext ?? throw new ArgumentNullException(nameof(applicationContext));
        }
        public async Task CreateUserAsync(User user)
        {

            await Task.CompletedTask;

        }

        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {

            // Sample code for executing query
            //using var connection = _applicationContext.CreateConnection();
            //var query = "Select count(*) from master";
            //var result = await connection.ExecuteScalarAsync<int>(query);
            var users = new List<User>
        {
            new User { Id = 1, Name = "John Doe" },
            new User { Id = 2, Name = "Jane Smith" },
            new User { Id = 3, Name = "Alice Johnson" }
        };
   
            return await Task.FromResult<IEnumerable<User>>(users);
           
        }

        public async Task<User> GetUserAsync(int id)
        {
            // Return a dummy user based on ID
            var user = new User
            {
                Id = id,
                Name = "John Doe"
            };
            return await Task.FromResult(user);
        }
    }
}
