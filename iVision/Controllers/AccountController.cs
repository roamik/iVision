using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using iVision.MODELS.Entities;
using iVision.MODELS.Options;
using iVision.MODELS.Resources;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace iVision.Controllers
{
    [Route("api/[controller]")]
    [AllowAnonymous]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IOptions<JWTOptions> _options;
        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager, IOptions<JWTOptions> options)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _options = options;
        }


        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody]UserResource model)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null)
            {
                ModelState.AddModelError("Email", "ERR_USER_NOT_FOUND");
            }
            else
            {
                var roles = await _userManager.GetRolesAsync(user);
                var result = await _signInManager.CheckPasswordSignInAsync(user, model.Password, false);
                if (!result.Succeeded) return BadRequest(ModelState);
                var claims = new List<Claim> {
                    new Claim( ClaimsIdentity.DefaultNameClaimType, user.UserName ),
                    new Claim( JwtRegisteredClaimNames.Sub, user.Email ),
                    new Claim( JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString() ),
                    new Claim( JwtRegisteredClaimNames.Sid, user.Id.ToString() ) // Set userid to token Sid claim
                };
                if (roles.Any())
                {
                    claims.AddRange(roles.Select(role => new Claim(JwtRegisteredClaimNames.Sub, role)));
                }
                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_options.Value.Key));
                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                var token = new JwtSecurityToken(
                    issuer: _options.Value.Issuer,
                    audience: _options.Value.Issuer,
                    claims: claims,
                    expires: DateTime.UtcNow.AddMinutes(30),
                    signingCredentials: creds);

                return Ok(new { token = new JwtSecurityTokenHandler().WriteToken(token), id = user.Id });
            }

            return BadRequest(ModelState);
        }



        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register([FromBody]UserResource model)
        {
            if (!ModelState.IsValid) { return BadRequest("Could not create token"); }
            if (await _userManager.FindByNameAsync(model.Username) != null)
            {
                ModelState.AddModelError("Email", "ERR_USER_ALREADY_EXISTS");
            }
            else
            {
                var user = new User { Email = model.Email, UserName = model.Username };
                var result = await _userManager.CreateAsync(user, model.Password);
                if (!result.Succeeded) { return BadRequest("Could not create token" + result.ToString()); }
                var claims = new[]
                {
                    new Claim(ClaimsIdentity.DefaultNameClaimType,user.UserName),
                    new Claim(JwtRegisteredClaimNames.Sub, user.Email),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    new Claim(JwtRegisteredClaimNames.Sid, user.Id.ToString()) // Set userid to token Sid claim
                };

                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_options.Value.Key));
                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                var token = new JwtSecurityToken(_options.Value.Issuer,
                    _options.Value.Issuer,
                    claims,
                    expires: DateTime.Now.AddMinutes(30),
                    signingCredentials: creds);

                return Ok(new { token = new JwtSecurityTokenHandler().WriteToken(token), id = user.Id });
            }

            return BadRequest("Could not create token");
        }



    }
}