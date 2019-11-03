using iVision.MODELS.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace iVision.DAL.Abstract.Services
{
    public interface IUsersService
    {
        Task<IEnumerable<User>> ListAsync();
    }
}
