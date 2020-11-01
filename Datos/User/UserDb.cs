using Datos.User.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Datos.User
{
    public class UserDb
    {
        public List<UserDbModel> ListUsers()
        {
            var ret = new[] {
                new UserDbModel()
                {
                    Id = 1,
                    Username = "rnexer",
                    Email = "rnexer@test.hn"
                },
                new UserDbModel()
                {
                    Id = 2,
                    Username = "rnexer2",
                    Email = "rnexer2@test.hn"
                }
            };

            return ret.ToList();
        }

        public UserDbModel GetById(int id)
        {
            return new UserDbModel()
            {
                Id = 1,
                Username = "rnexer",
                Email = "rnexer@test.hn"
            };
        }
    }
}
