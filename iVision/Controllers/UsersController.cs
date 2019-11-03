using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using iVision.DAL.Abstract;
using iVision.DAL.Abstract.Services;
using iVision.DAL.Abstract.UnitOfWork;
using iVision.DAL.Concrete;
using iVision.MODELS;
using iVision.MODELS.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace iVision.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsersService _usersService;

        public UsersController(IUsersService usersService)
        {
            _usersService = usersService;
        }

        [HttpGet]
        public async Task<IEnumerable<User>> GetAllAsync()
        {
            var users = await _usersService.ListAsync();
            return users;
        }

    }
}