using iVision.DAL.Abstract;
using iVision.DAL.Abstract.UnitOfWork;
using iVision.MODELS;
using iVision.MODELS.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace iVision.DAL.Concrete
{
    public class UsersRepository : BaseRepository, IUsersRepository
    {
        public UsersRepository(ApplicationContext context) : base(context)
        { }

        public async Task DeleteUserAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<User> GetUserByIDAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<User>> ListAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task InsertUserAsync()
        {
            throw new NotImplementedException();
        }

        public async Task UpdateUserAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
