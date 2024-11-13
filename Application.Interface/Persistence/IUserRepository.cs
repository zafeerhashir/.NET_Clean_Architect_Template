using Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interface.Persistence
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAllUsersAsync();
        Task<User> GetUserAsync(int id);
        Task CreateUserAsync(User user);
    }
}
