using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using P8.Server.Controllers;
using P8.Shared;

namespace P8.Server.DB
{
    public class UserProvider
    {
        private readonly UserDbContext _context;
        private readonly ILogger _logger;
        public UserProvider(UserDbContext context, ILoggerFactory loggerFactory)
        {
            this._context = context;
            this._logger = loggerFactory.CreateLogger("ClotheProvider");
        }
        public User getUser()
            =>this._context.Users.ToList().Aggregate((c,s)=> c.ID>s.ID?c:s);

        public async Task CreateUserp(User user)
        {

            int Id = this._context.Users.ToList().Select(s=>s.ID).Max();
            user.ID= Id + 1;
            // await _context.Users.Remove(lastUser).Entity;
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
        }
    }
}
