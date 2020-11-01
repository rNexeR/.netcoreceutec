using Aplicativa.Common;
using Datos.User;
using Datos.User.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicativa.User.Queries
{
    public class GetUserById
    {
        private UserDb UserDb { get; set; }

        public GetUserById()
        {
            this.UserDb = new UserDb();
        }

        public UserDbModel GetById(int id)
        {
            var model = new UserDbModel();

            model.Username.IsNullOrEmpty();

            var number = 8;

            var isLessThanZero = number.IsLessThanZero();

            if(model.Username == null || model.Username == "")
            {
                throw new ArgumentException("Username is required");
            }

            return this.UserDb.GetById(id);
        }
    }
}
