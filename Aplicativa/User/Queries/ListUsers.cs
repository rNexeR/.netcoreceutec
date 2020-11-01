using Datos.User;
using Datos.User.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicativa.User.Queries
{
    public class ListUsers
    {
        private UserDb UserDb { get; set; }

        public ListUsers()
        {
            this.UserDb = new UserDb();
        }

        public List<UserDbModel> Execute()
        {
            return this.UserDb.ListUsers();
        }
    }
}
