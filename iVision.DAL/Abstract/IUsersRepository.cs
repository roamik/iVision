using iVision.MODELS.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace iVision.DAL.Abstract
{
    public interface IUsersRepository
    {
        Task<IEnumerable<User>> ListAsync();
        Task<User> GetUserByIDAsync(Guid id);
        Task InsertUserAsync();
        Task DeleteUserAsync(Guid id);
        Task UpdateUserAsync(Guid id);
    }
}
