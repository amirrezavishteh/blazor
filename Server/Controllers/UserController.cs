using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using P8.Server.DB;
using P8.Shared;


namespace P8.Server.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class UserController : Controller
    {
        public UserController (UserProvider provider)
        {
            this._provider=provider;
        }
        private readonly UserProvider _provider;
        [HttpGet]
        [Route("getUserInDb")]
        public User getUserInDb()
            => this._provider.getUser();

        [HttpPost]
        [Route("CreateUser")]
        public async Task<User> CreateUser(User user)
        {
            await this._provider.CreateUserp(user);
            return user;
        }
    }
}