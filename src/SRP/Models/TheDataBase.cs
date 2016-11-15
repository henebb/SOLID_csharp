using System.Collections.Generic;
using System.Linq;
using SOLID_csharp.Interfaces;

namespace SOLID_csharp.Models
{
    public class TheDataBase : IAmTheDataBase
    {
        private readonly IList<User> _users;

        public TheDataBase()
        {
            _users = new List<User>();
        }

        public void Save(User user)
        {
            if (_users.Any(u => u.Email == user.Email))
            {
                return;
            }

            _users.Add(user);
        }
    }
}