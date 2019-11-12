using iVision.DAL.Abstract;
using iVision.DAL.Abstract.Services;
using iVision.MODELS.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace iVision.DAL.Concrete.Services
{
    public class UsersService : IUsersService
    {
        private readonly IUsersRepository _usersRepository;

        public UsersService(IUsersRepository usersRepository)
        {
            this._usersRepository = usersRepository;
        }

        public async Task<IEnumerable<User>> ListAsync()
        {
            return await _usersRepository.ListAsync();
        }

        //public async Task<User> GetUser()
        //{
        //    return await _usersRepository.GetUserByIDAsync();
        //}
    }
}
